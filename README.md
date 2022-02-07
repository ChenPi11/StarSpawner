
``` 

                                                |         o   |         |              
,---.,---.,---.,---.,---.,---.,---.,---.,---.   |--- ,---..   |---..   .|--- ,---.,---.
|    |   ||   ||    |   ||   ||    |   ||   |---|    |    |---|   ||   ||    |---'|    
`---'`---'`   '`---'`---'`   '`---'`---'`   '   `---'`    `   `---'`---'`---'`---'`    
                                                                                       
```

<p align="center">
  <a hrdf="./LICENSE"><img src="https://img.shields.io/github/license/Dynesshely/conconcon-tri-buter?style=for-the-badge"></img></a>
  <a hrdf=""><img src="https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white"></img></a>
  <a hrdf=""><img src="https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black"></img></a>
  <a hrdf=""><img src="https://img.shields.io/badge/mac%20os-000000?style=for-the-badge&logo=macos&logoColor=F0F0F0"></img></a>
</p>

------

</br>

# 中文文档

想要装13吗? 来这就对了!

## 它能做什么
1. 能快速增加项目的 Commits 数量

2. 能快速填满 GitHub / Gitlab / Gitee 的 Contributions
3. 能拿来装13

## 发布
本地编译执行此命令 (基于 .NET 5, 请确保安装了有效的 SDK)

``` powershell
dotnet publish -r win-x86 -c release -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true
```

## 下载
1. 在 GitHub Release 中, 下载最新版本的 exe 程序, 并存放到 需要刷 Commits 的项目 的 git 根目录下 (请确保该目录含有 `.git` 这个隐藏文件夹)
2. 运行下载的 exe 程序，并按照提示进行操作

## 使用
菜单目前有四项
1. Simply contribute every selected day

   说明: 从 n 天前开始到今天，每天提交 r 次 Commits (r 可选择 固定 (不限次数) 或者 随机 (一天最多 40 次 (可自行修改源码解除限制) ), Commits 为随机字符串

2. Simply contribute with random lively commit message

   说明: 功能类似 `选项 1`, 但 Commits 为拟真消息, 格式如下:

   * type(scope): subject

   * type: 类型 (feat, fix, docs, style, refactor, test, chore)

   * scope: 变动范围, 可选, 多为文件名或目录

   * subject: 简要概述变动内容及作用

   (此模板参照 [阮一峰老师の博客](http://www.ruanyifeng.com/blog/2016/01/commit_message_change_log.html) 生成)

3. Lively contribute with lively commit message

   说明: 功能类似 `选项 1`, 但允许手动设置开始和结束日期, 且 Commits 为拟真消息

4. Lively contribute with lively commit message with density

   说明: 功能类似 `选项 1`, 但增加密度提交功能 (🎷吹爆):  需要手动设置 密度 和 每日最多提交数, 且允许手动设置开始和结束日期, Commits 为拟真消息

## 它是如何工作的
git commit 命令允许使用 --date 参数指定提交日期, 而 GitHub 通过 Commits 的日期计算 Contributions, 本程序通过重复 ”创建文件, 指定提交日期, 提交, 删除“ 这一流程的方式, 以假乱真, 让你的 GitHub Contributions 有13可装!

------

</br>

# English Docs

Zhuangbilize? Right Here!

## What can it do
Create fake Commits 2 ur Repository, & fake contributions on GitHub / GitLab / Gitee

## Publish
``` powershell
dotnet publish -r win-x86 -c release -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true
```

## Download
1. In GitHub Release, download the latest version of the exe program and store it in the Git Root Directory of ur Project that needs Commits (ensure that contains a hidden ".git" folder)

2. Run

## Use

The menu currently has four items
1. Simply contribute every selected day
    Note: from n days ago to today, submit r Commits every day (R can choose fixed (unlimited times) or random (up to 40 times a day (you can modify the source code to remove the restriction)), and the Commits r random strings

2. Simply contribute with random lively commit message
    Note: the function is similar to option 1, but the Commits r pseudo true messages. The format is as follows:

  * type(scope): subject

  * Type: type (feat, fix, docs, style, refactor, test, chore)

  * Scope: change range, optional, mostly file name or directory

  * Subject: a brief overview of changes and functions
    (this template refers to [Ruan Yifeng's blog]( http://www.ruanyifeng.com/blog/2016/01/commit_message_change_log.html ))

3. Lively contribute with lively commit message
    Note: the function is similar to 'option 1', but it is allowed to manually set the start and end dates, and the Commits r pseudo true messages
4. Lively contribute with lively commit message with density
    Note: the function is similar to option 1, but the density submission function is added（ 🎷 Blow up): it is necessary to manually set the density and the maximum number of submissions per day, and it is allowed to manually set the start and end dates. Commits r pseudo true messages

**Enjoy it!**

## How it works

"git commit" command allows you to specify a submission date by using a --date parameter, GitHub calculates the contributions based on the date of the Commits, This procedure creates documents by Repeating "creating data, specifying the submission date, submitting and deleting", to assist u in Zhuangbility

------
