import http from "./httpService";
const apiEndpoint = "/Translator";

export function getLanguages() {
    return http.get(apiEndpoint + "/GetLanguages");
}
export function GetGroupedWords(data) {
    return http.get(apiEndpoint + `/GetGroupedWords?LanguageFromId=${data.languageFromId}&LanguageToId=${data.languageToId}&Text=${data.text}`);
}