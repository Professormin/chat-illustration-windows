# 微信对话示意图

为讲解和演示制作群聊或一对一聊天示意图。可以填写化名和消息，选用本地头像，展示语音时长和转写，导出带示意标记的 PNG。

## Windows 使用

双击 ChatIllustration.exe。启动器释放内置页面到当前用户的本地应用数据目录，并用默认浏览器打开。无需安装服务或创建账号。也可以直接打开 template.html。录音取决于浏览器的麦克风权限，中文语音识别要求浏览器支持本机语言包。示例均为虚构。

## 从源码构建

在装有 .NET Framework 4.x 的 64 位 Windows 上运行 powershell -ExecutionPolicy Bypass -File build.ps1。产物在 dist。用 Get-FileHash -Algorithm SHA256 核对发布文件。

源码采用 MIT 许可证。
