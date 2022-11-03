using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using Translator_app.Model;
using Translator_app.Services;
using Translator_app.ViewModel;

namespace Translator_app.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TranslatorController : Controller
    {
        private readonly ITranslatorServices _translatorServices;
        private readonly ILogger _logger;
        public TranslatorController(ITranslatorServices translatorServices, ILogger<TranslatorController> logger)
        {
            _translatorServices = translatorServices ?? throw new ArgumentNullException(nameof(translatorServices));
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        ///Translator/GetLanguages
        [HttpGet("[action]")]
        public IActionResult GetLanguages()
        {
            try
            {
                _logger.LogInformation($"Incoming request at GetLanguages endpoint... {DateTime.UtcNow.ToLongTimeString()}");
                var _allLanguages = _translatorServices.GetAllLanguage();

                return Ok(_allLanguages);
            }
            catch (Exception ex)
            {
                _logger.LogError($"FAILED: GetLanguages- {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpGet("[action]")]
        public IActionResult GetGroupedWords(string LanguageFromId, string LanguageToId, string Text)
        {
            try
            {
                _logger.LogInformation($"Incoming request at GroupedWords endpoint... {DateTime.UtcNow.ToLongTimeString()}");
                _logger.LogInformation($"LanguageFromId = {LanguageFromId}, LanguageToId = {LanguageToId}, Text = {Text}");
                var searchingParameter = new SearchingParameter(Text, LanguageFromId, LanguageToId);

                if (searchingParameter == null || string.IsNullOrEmpty(searchingParameter.Text) || string.IsNullOrEmpty(searchingParameter.LanguageFromId) || string.IsNullOrEmpty(searchingParameter.LanguageToId))
                    return NoContent();

                var _getWords = _translatorServices.GroupedTranslateWord(searchingParameter);
                return Ok(_getWords);
            }
            catch (Exception ex)
            {
                _logger.LogError($"FAILED: GetLanguages- {ex.Message}");

                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}

