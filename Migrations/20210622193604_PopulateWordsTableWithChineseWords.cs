﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Translator_app.Migrations
{
    public partial class PopulateWordsTableWithChineseWords : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
           table: "Word",
           columns: new[] { "TextId", "Text", "LanguageId" },
           values: new object[,] {
           {"1","账号持有人姓名", "ZH"},
            {"2","会计与财务", "ZH"},
            {"3","已激活", "ZH"},
            {"4","添加费用", "ZH"},
            {"5","添加新备注", "ZH"},
            {"6","添加新项", "ZH"},
            {"7","添加新供应商", "ZH"},
            {"8","额外编辑任务/管理", "ZH"},
            {"9","管理权限", "ZH"},
            {"10","推广费用管理", "ZH"},
            {"11","机构", "ZH"},
            {"12","支付宝账号", "ZH"},
            {"13","分析", "ZH"},
            {"14","通知", "ZH"},
            {"15","年度关账，纳税申报与审计", "ZH"},
            {"16","年度评估反馈", "ZH"},
            {"17","Apollo 权限ID-DQ ", "ZH"},
            {"18","Apollo 权限ID-RE", "ZH"},
            {"19","Caspian 上申请付费", "ZH"},
            {"20","AR 追踪跟进", "ZH"},
            {"21","自动化问卷", "ZH"},
            {"22","Bamboo", "ZH"},
            {"23","银行账号", "ZH"},
            {"24","银行地址", "ZH"},
            {"25","银行名字", "ZH"},
            {"26","BI-跨部门协助", "ZH"},
            {"27","BI-跨办公室协助", "ZH"},
            {"28","BI- 设计，插图，图形布局，CSS", "ZH"},
            {"29","BI-开发解决方案文件", "ZH"},
            {"30","BI-特定分析（轮次，支出成本等)", "ZH"},
            {"31","出账", "ZH"},
            {"32","BR协助", "ZH"},
            {"33","支行名字/ID", "ZH"},
            {"34","Bravo 角色", "ZH"},
            {"35","Bravo 用户", "ZH"},
            {"36","预算准备", "ZH"},
            {"37","企业管理", "ZH"},
            {"38","致电新走访员", "ZH"},
            {"39","沟通-走访员", "ZH"},
            {"40","沟通/会议-客户，SM", "ZH"},
            {"41","沟通/会议-内部", "ZH"},
            {"42","沟通-广告供应商", "ZH"},
            {"43","电话&邮件", "ZH"},
            {"44","取消", "ZH"},
            {"45","现金预测", "ZH"},
            {"46","Caspian", "ZH"},
            {"47","Caspian（进入，管理）", "ZH"},
            {"48","Caspian内部用户", "ZH"},
            {"49","Caspian主用户", "ZH"},
            {"50","Caspian 角色", "ZH"},
            {"51","申诉处理", "ZH"},
            {"52","选择其中一个", "ZH"},
            {"53","协助客户", "ZH"},
            {"54","客户", "ZH"},
            {"55","客户协议创建与跟进", "ZH"},
            {"56","客户沟通", "ZH"},
            {"57","客户报告-Excel", "ZH"},
            {"58","客户报告", "ZH"},
            {"59","客户沟通汇报", "ZH"},
            {"60","客户/前端-跟进", "ZH"},
            {"61","客户/前端-会议", "ZH"},
            {"62","CN协助", "ZH"},
            {"63","电话推销", "ZH"},
            {"64","备注", "ZH"},
            {"65","备注：", "ZH"},
            {"66","备注项", "ZH"},
            {"67","公司名称", "ZH"},
            {"68","终止合同", "ZH"},
            {"69","合同到期日期", "ZH"},
            {"70","复制", "ZH"},
            {"71","成本，招标书", "ZH"},
            {"72","国家代码", "ZH"},
            {"73","录入新供应商", "ZH"},
            {"74","创建", "ZH"},
            {"75","创建客户的建议/提议", "ZH"},
            {"76","创建过程/流程", "ZH"},
            {"77","创建过程/程序", "ZH"},
            {"78","货款录入及批准", "ZH"},
            {"79","跨部门协助-BI", "ZH"},
            {"80","跨部门协助-DQ", "ZH"},
            {"81","跨部门协助-财务", "ZH"},
            {"82","跨部门协助-IT", "ZH"},
            {"83","跨部门协助-KAM", "ZH"},
            {"84","跨部门协助-市场", "ZH"},
            {"85","跨部门协助-RM", "ZH"},
            {"86","跨部门协助-销售", "ZH"},
            {"87","货币", "ZH"},
            {"88","表格数据核对", "ZH"},
            {"89","数据筛选，核对及匹配", "ZH"},
            {"90","数据", "ZH"},
            {"91","删除", "ZH"},
            {"92","部门", "ZH"},
            {"93","DQ主管", "ZH"},
            {"94","编辑", "ZH"},
            {"95","编辑Timesheet条目", "ZH"},
            {"96","编辑报告（一轮编辑）", "ZH"},
            {"97","编辑任务", "ZH"},
            {"98","编辑费用处理", "ZH"},
            {"99","邮件", "ZH"},
            {"100","邮件", "ZH"},
            {"101","员工出勤率考核", "ZH"},
            {"102","员工福利支付", "ZH"},
            {"103","员工反馈", "ZH"},
            {"104","结束", "ZH"},
            {"105","结束日期", "ZH"},
            {"106","结束时间", "ZH"},
            {"107","在会计软件中输入数据", "ZH"},
            {"108","在现有条目上重新输入数据：", "ZH"},
            {"109","EU 协助", "ZH"},
            {"110","导出", "ZH"},
            {"111","费用", "ZH"},
            {"112","费用类型", "ZH"},
            {"113","费用", "ZH"},
            {"114","工作伙伴", "ZH"},
            {"115","名字", "ZH"},
            {"116","名字", "ZH"},
            {"117","跟进", "ZH"},
            {"118","星期五", "ZH"},
            {"119","完整编辑", "ZH"},
            {"120","全球反诈骗团队协作", "ZH"},
            {"121","多办公室协作", "ZH"},
            {"122","医疗健康帮助", "ZH"},
            {"123","隐藏新的评论/备注", "ZH"},
            {"124","雇佣/面试", "ZH"},
            {"125","雇佣/员工入职流程", "ZH"},
            {"126","Hold-A 管理", "ZH"},
            {"127","Hold-B 管理", "ZH"},
            {"128","主页", "ZH"},
            {"129","IBAN编号/银行账户账号", "ZH"},
            {"130","报告ID", "ZH"},
            {"131","IN 协助", "ZH"},
            {"132","独立用户", "ZH"},
            {"133","内部沟通", "ZH"},
            {"134","内部询问", "ZH"},
            {"135","内部汇报", "ZH"},
            {"136","跨办公室沟通", "ZH"},
            {"137","费用相关事宜", "ZH"},
            {"138","IO 沟通", "ZH"},
            {"139","是否为团队成员？", "ZH"},
            {"140","是否为供应商？", "ZH"},
            {"141","IT管理任务", "ZH"},
            {"142","KAM主管", "ZH"},
            {"143","KPI 计算", "ZH"},
            {"144","最后一次登录时间", "ZH"},
            {"145","姓氏", "ZH"},
            {"146","姓氏", "ZH"},
            {"147","主要研究", "ZH"},
            {"148","Timesheet 条目列表", "ZH"},
            {"149","列表形式", "ZH"},
            {"150","登出", "ZH"},
            {"151","承包商，供应商管理", "ZH"},
            {"152","材料", "ZH"},
            {"153","修改", "ZH"},
            {"154","星期一", "ZH"},
            {"155","更多", "ZH"},
            {"156","姓名", "ZH"},
            {"157","网络事项", "ZH"},
            {"158","新雇员-培训", "ZH"},
            {"159","Timesheet 新项录入", "ZH"},
            {"160","下一项", "ZH"},
            {"161","否", "ZH"},
            {"162","办公室", "ZH"},
            {"163","办公室主管", "ZH"},
            {"164","职位名称", "ZH"},
            {"165","OH和属性计算", "ZH"},
            {"166","选择性费用只有在开始状态为Reviewed才会生效", "ZH"},
            {"167","选择性费用", "ZH"},
            {"168","数据整理及模板制作", "ZH"},
            {"169","其他任务/杂项", "ZH"},
            {"170","利润分析准备", "ZH"},
            {"171","团队沟通", "ZH"},
            {"172","付款方式", "ZH"},
            {"173","付款方式", "ZH"},
            {"174","员工发展沟通", "ZH"},
            {"175","员工管理", "ZH"},
            {"176","员工表现追踪", "ZH"},
            {"177","PH 协助", "ZH"},
            {"178","手机号码", "ZH"},
            {"179","手机号码", "ZH"},
            {"180","电话号码不正确", "ZH"},
            {"181","定位", "ZH"},
            {"182","工作计划安排", "ZH"},
            {"183","请选择", "ZH"},
            {"184","推广发布", "ZH"},
            {"185","偏好语言", "ZH"},
            {"186","会议准备", "ZH"},
            {"187","每月汇报准备", "ZH"},
            {"188","每周汇报准备", "ZH"},
            {"189","之前的", "ZH"},
            {"190","费用重设", "ZH"},
            {"191","流程管理和回顾", "ZH"},
            {"192","流程优化", "ZH"},
            {"193","资料", "ZH"},
            {"194","项目设计", "ZH"},
            {"195","项目回顾（与运营/项目经理）", "ZH"},
            {"196","项目设置/指南准备/概述汇报", "ZH"},
            {"197","培训", "ZH"},
            {"198","带薪休假", "ZH"},
            {"199","质量检查（二轮编辑）", "ZH"},
            {"200","接受培训", "ZH"},
            {"201","招聘", "ZH"},
            {"202","报告自动化", "ZH"},
            {"203","汇报/状态跟踪/跟进", "ZH"},
            {"204","重设Caspian密码", "ZH"},
            {"205","盈利", "ZH"},
            {"206","查看问卷/评估员指南", "ZH"},
            {"207","修订-数据分析相关", "ZH"},
            {"208","修订-客户相关", "ZH"},
            {"209","修订-KAM相关", "ZH"},
            {"210","RM主管", "ZH"},
            {"211","角色", "ZH"},
            {"212","Rulez", "ZH"},
            {"213","销售到运营间的转换", "ZH"},
            {"214","星期六", "ZH"},
            {"215","保存", "ZH"},
            {"216","保存备注", "ZH"},
            {"217","保存费用", "ZH"},
            {"218","分配", "ZH"},
            {"219","搜索", "ZH"},
            {"220","选择机构", "ZH"},
            {"221","选择任务", "ZH"},
            {"222","选择任务", "ZH"},
            {"223","自行分配", "ZH"},
            {"224","新加坡协助", "ZH"},
            {"225","社交媒体", "ZH"},
            {"226","花费小时数", "ZH"},
            {"227","开始", "ZH"},
            {"228","开始-结束", "ZH"},
            {"229","开始日期", "ZH"},
            {"230","开始时间", "ZH"},
            {"231","星期天", "ZH"},
            {"232","主管姓名", "ZH"},
            {"233","协助", "ZH"},
            {"234","Surfmerchants", "ZH"},
            {"235","问卷名称", "ZH"},
            {"236","转换为", "ZH"},
            {"237","任务", "ZH"},
            {"238","任务：", "ZH"},
            {"239","正确的格式应为 'hh:mm'", "ZH"},
            {"240","此部分需要进行填写。", "ZH"},
            {"241","星期四", "ZH"},
            {"242","轮次", "ZH"},
            {"243","一轮", "ZH"},
            {"244","二轮", "ZH"},
            {"245","Timesheet", "ZH"},
            {"246","Timesheet 用户名称", "ZH"},
            {"247","今天", "ZH"},
            {"248","跟踪处理", "ZH"},
            {"249","自我培训", "ZH"},
            {"250","培训-自己/团队成员/外部人员", "ZH"},
            {"251","培训/反馈评估员", "ZH"},
            {"252","培训/教导团队成员/外部成员", "ZH"},
            {"253","翻译事宜", "ZH"},
            {"254","指南或者其他文档等的翻译", "ZH"},
            {"255","星期二", "ZH"},
            {"256","填写备注", "ZH"},
            {"257","输入搜索关键词", "ZH"},
            {"258","US 协助", "ZH"},
            {"259","使用键盘上的方向键(上、下)来更改选择。可以通过标题中的斜线调整列的大小，可以通过第一个单元格中的斜线调整行大小。", "ZH"},
            {"260","用户ID", "ZH"},
            {"261","用户名", "ZH"},
            {"262","用户类型", "ZH"},
            {"263","供应商用户", "ZH"},
            {"264","增值税/消费税的税务准备和申报", "ZH"},
            {"265","供应商", "ZH"},
            {"266","供应商费用", "ZH"},
            {"267","供应商ID", "ZH"},
            {"268","供应商", "ZH"},
            {"269","供应商名称", "ZH"},
            {"270","供应商付款情况", "ZH"},
            {"271","轮次", "ZH"},
            {"272","星期三", "ZH"},
            {"273","工作日", "ZH"},
            {"274","西部联盟电报公司地址", "ZH"},
            {"275","整周", "ZH"},
            {"276","是", "ZH"},
           });
        }


        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}