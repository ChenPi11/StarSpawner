
<p align="center">
  <pre align="center">
                                                |         o   |         |              
,---.,---.,---.,---.,---.,---.,---.,---.,---.   |--- ,---..   |---..   .|--- ,---.,---.
|    |   ||   ||    |   ||   ||    |   ||   |---|    |    |---|   ||   ||    |---'|    
`---'`---'`   '`---'`---'`   '`---'`---'`   '   `---'`    `   `---'`---'`---'`---'`    
  </pre>
</p>

<p align="center">
  <a href="./LICENSE"><img src="https://img.shields.io/github/license/Dynesshely/conconcon-tri-buter?style=for-the-badge"></img></a>
  <a href=""><img src="https://img.shields.io/badge/Windows-0078D6?style=for-the-badge&logo=windows&logoColor=white"></img></a>
  <a href=""><img src="https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black"></img></a>
  <a href=""><img src="https://img.shields.io/badge/mac%20os-000000?style=for-the-badge&logo=macos&logoColor=F0F0F0"></img></a>
</p>

</br>

<p align="center">
  🌐 <a href="#-中文文档">中文</a> | <a href="#-english-docs">English</a><br>
已与 🅱️ <a href="https://blog.catrol.cn/2022/02/07/save-your-github/" target="_blank">调皮豆干 の 博客</a> 同步
</p>

------

| 目前 🎠 | Hi there 🎠 |
| ----- | ----- |
| 🍔 控制台应用暂缓开发, 功能较为齐全 | 🍔 Development of Console App paused, it had got more complete functions |
| 🥓 [图形化版本](#GraphicalVersion)大体完毕, 期待使用 | 🥓 Graphical version is mostly developed, welcome to test it |
| 🎉 多多支持呀 ! | 🎉 Support us ! |

------

# 📋 中文文档

想要装13吗? 来这就对了!

## 🎇 效果展示
> 下图图3(左下角)中密集区块生成是在指定区间(2015-6-14 到 2015-9-27)固定每日提交次数, 密度 0.7 时的效果

<p align="center"><img src="https://source.catrol.cn/img/blog-catrol/posts/save-your-github/contribution-graph.png" alt="带密度的全年随机生成 (密度: 0.1 ~ 0.3 时)"></img></p>
<p align="center">带密度的全年随机生成 (密度: 0.1 ~ 0.3 时)</p>
<p align="center"><img src="https://source.catrol.cn/img/blog-catrol/posts/save-your-github/contribution-final-effect.png" alt="混合带密度的随机生成与不带密度的全年覆盖生成"></img></p>
<p align="center">混合带密度的随机生成与不带密度的全年覆盖生成</p>

## 🍗 它能做什么
1. 能快速增加项目的 Commits 数量

2. 能快速填满 GitHub / Gitlab / Gitee 的 Contributions
3. 能拿来装13

## 🪦 发布
本地编译执行此命令 (基于 .NET 5, 请确保安装了有效的 SDK)

``` powershell
dotnet publish -r win-x86 -c release -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true
```
另外, 不同平台请指定 -r 参数 <br>
可选 (macOS 选项未知, 可自行探索):
1. win-x86
2. win-x64
3. linux-x86
4. linux-x64

## ⬇️ 下载
1. 在 GitHub Release 中, 下载最新版本的 exe 程序, 并存放到 需要刷 Commits 的项目 的 git 根目录下 (请确保该目录含有 `.git` 这个隐藏文件夹)
2. 运行下载的 exe 程序，并按照提示进行操作

## 🎉 使用
### ⚒️ 先决条件
1. 需要完整的 git 工具安装
2. 确保终端可以使用 git 命令
3. 确保本地仓库的 origin 源已经添加 GitHub 或是其它托管平台的仓库地址
4. 确保本地密钥配置完善, 可以直接 push , 否则请手动 push

### 🧭 如何使用
菜单目前有四项
1. Simply contribute every selected day

   说明: 从 n 天前开始到今天，每天提交 r 次 Commits (r 可选择 固定 (不限次数) 或者 随机 (一天最多 40 次 (可自行修改源码解除限制) ), Commits 为随机字符串

2. Simply contribute with random lively commit message

   说明: 功能类似 `选项 1`, 但 Commits 为拟真消息, 格式: `type(scope): subject` 详解如下:

   * type: 类型 (feat, fix, docs, style, refactor, test, chore)

   * scope: 变动范围, 可选, 多为文件名或目录

   * subject: 简要概述变动内容及作用

   (此模板参照 [阮一峰老师の博客](http://www.ruanyifeng.com/blog/2016/01/commit_message_change_log.html) 生成)

3. Lively contribute with lively commit message

   说明: 功能类似 `选项 1`, 但允许手动设置开始和结束日期, 且 Commits 为拟真消息

4. Lively contribute with lively commit message with density

   说明: 功能类似 `选项 1`, 但增加密度提交功能 (🎷吹爆(正态分布随机数实现)):  需要手动设置 密度 和 每日最多提交数, 且允许手动设置开始和结束日期, Commits 为拟真消息

## 🎢 它是如何工作的
git commit 命令允许使用 --date 参数指定提交日期, 而 GitHub 通过 Commits 的日期计算 Contributions, 本程序通过重复 ”创建文件, 指定提交日期, 提交, 删除“ 这一流程的方式, 以假乱真, 让你的 GitHub Contributions 有13可装!

------

</br>

# 📋 English Docs

Want to pretend to be awesome? Here you go!

## 🎇 Show effects
> The dense block generation in Figure 3 (lower left corner) below is the effect when the number of daily submissions is fixed in the specified interval (2015-6-14 to 2015-9-27) and the density is 0.7

<p align="center"><img src="https://source.catrol.cn/img/blog-catrol/posts/save-your-github/contribution-graph.png" alt="Full with density Years are randomly generated (density: 0.1 ~ 0.3)"></img></p>
<p align="center">Full with density Years are randomly generated (density: 0.1 ~ 0.3)</p>
<p align="center"><img src="https://source.catrol.cn/img/blog-catrol/posts/save-your-github/contribution-final-effect.png" alt="Mixed Band Random generation of density and year-round coverage generation without density"></img></p>
<p align="center">Mixed Band Random generation of density and year-round coverage generation without density</p>

## 🍗 What can it do
1. Can quickly increase the number of Commits of the project
2. Contributions that can quickly fill up GitHub / Gitlab / Gitee
3. Can be used to pretend to be very powerful

## 🪦 Publish
Compile and execute this command locally (based on .NET 5, make sure you have a valid SDK installed)
``` powershell
dotnet publish -r win-x86 -c release -p:PublishSingleFile=true -p:IncludeNativeLibrariesForSelfExtract=true
```
In addition, please specify the `-r` parameter for different platforms <br>
Options (macOS options are unknown, you can explore by yourself):
1. win-x86
2. win-x64
3. linux-x86
4. linux-x64

## ⬇️ Download
1. In GitHub Release, download the latest version of the exe program and store it in the Git Root Directory of our Project that needs Commits (ensure that contains a hidden ".git" folder)
2. Run the downloaded exe program and follow the prompts

## 🎉 Use
### ⚒️ Prerequisites
1. Requires full git tool installation
2. Make sure that you can use the git command
3. Make sure that the origin of the local repository has added the repository address of GitHub or other hosting platforms
4. Make sure that the local key configuration is complete, you can push directly, otherwise please push manually

### 🧭 How to use?
The menu currently has four items
1. Simply contribute every selected day

   Description: Commits r times a day from n days ago to today (r can choose fixed (unlimited times) or random (up to 40 times a day (you can modify the source code to lift the limit)), Commits is a random string

2. Simply contribute with random lively commit message

   Description: The function is similar to `Option 1`, but Commits is a real message, format: `type(scope): subject` The details are as follows:
   
   * type: type (feat, fix, docs, style, refactor, test, chore)
   
   * scope: scope of change, optional, mostly file name or directory
   
   * subject: Brief overview of the changes and their effects
   
   (This template is generated by referring to [Mr. Ruan Yifeng's blog](http://www.ruanyifeng.com/blog/2016/01/commit_message_change_log.html))
   
3. Lively contribute with lively commit message

   Description: Similar to `Option 1`, but allows manual setting of start and end dates, and Commits is a simulacrum message
   
4. Lively contribute with lively commit message with density

   Description: The function is similar to `Option 1`, but the density submission function is added (🎷Blowout (normally distributed random number implementation)): You need to manually set the density and the maximum number of submissions per day, and allow you to manually set the start and end dates. Commits is Realistic news

## 🎢 How it works

The git commit command allows the use of the `--date` parameter to specify the commit date, and GitHub calculates Contributions by the date of Commits. This program repeats the process of "creating files, specifying commit dates, committing, and deleting" this process, to make your GitHub fake. Contributions look awesome!

# GraphicalVersion

<p align="center">
  🌐 <a href="#%EF%B8%8F-图形版本中文文档">中文</a> | <a href="#%EF%B8%8F-graphical-english-docs">English</a><br>
尚未与 🅱️ <a href="https://blog.catrol.cn/2022/02/07/save-your-github/" target="_blank">调皮豆干 の 博客</a> 同步
</p>

## 🎞️ 图形版本中文文档
### ⚒️ 先决条件
首先确保你的仓库可以正确满足控制台版本(即: conconcon-tri-buter.exe)的所有要求与先决条件, 再尝试满足图形版本的使用

### 🧭 如何使用
1. 拷贝最新的 Release cctb-wpf.zip 中的两个程序至 .git 文件夹所在根目录
2. 执行 cctb-wpf.exe
3. 选择所要提交的日期, 并设置提交数
4. 开始提交

### 🪦 发布
确保 clone 完整源码, 保证 `cctb-wpf` 与 `conconcon-tri-buter` 两个项目源码完整, 并置于同一目录下 <br>
使用命令行工具 (cmd / powershell) 切换目录至 `cctb-wpf` 目录下<br>
执行:
``` PS
dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained false
```
`-r` 参数可替换选项与 控制台版本 一致, 参见本 README.md 前文部分

## 🎞️ Graphical English Docs
### ⚒️ Prerequisites
Make sure your config is ready for conconcon-tri-buter.exe (Console Version) first, then Graphical Version

### 🧭 How to use
1. Copy latest Released two programs in cctb-wpf.zip into root directory where .git directory are
2. Execute cctb-wpf.exe
3. Select dates that to commit, and set commit numbers
4. Start commit

### 🪦 Publish
Make sure you have total source code, and the `cctb-wpf` folder and `conconcon-tri-buter` folder are in same path<br>
Use cmd or powershell and change directory to `cctb-wpf` folder<br>
Execute:
``` PS
dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained false
```
Arguments for `-r` are same with Console Version part in this README.md
