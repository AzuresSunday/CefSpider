![CefSpider](https://raw.githubusercontent.com/robyle/CefSpider/master/src/Resources/CefSpiderLogo.png)

欢迎大家给我一个Star,你的Star是该项目前进的动力！

## CefSpider设计图

![思维导图](https://raw.githubusercontent.com/robyle/CefSpider/master/images/CefSpider.jpg)

CefSpider 产品开发代号为“车风”，后面相关说明可能以'车风'代替进行描述，该项目以Cef（Chromium Embedded Framework）为内置引擎，衍生出不同高性能爬虫！ 开源的浏览器特性，高效且快速的页面渲染能力.我们采用的.NET支持的浏览器[CefSharp](https://github.com/cefsharp/CefSharp/).发布必须基于MIT授权.

## 快来加入群聊【CefSpider交流群】(群号[64360678](https://jq.qq.com/?_wv=1027&k=5tBcDuQ))，发现精彩内容。


![交流群二维码](https://raw.githubusercontent.com/robyle/CefSpider/master/images/CefSpider_Code.png)

大家优先考虑通过Github提交issue，这样遇到解决的问题后来者可以自行解决！


## 特性

- 支持 HTML5, CSS3, JS, HTML5 Video, WebGL 3D, 等
- 多选项卡支持
- 地址栏支持 (默认支持百度搜索)
- 后退，前进，停止，刷型
- 开发者工具
- 搜索栏 (可以高亮显示实例)
- 下载器管理
- 自定义错误页面
- 自定义右击菜单
- 轻松添加特定于供应商的品牌、按钮或热键
- 可以查看在线和离线页面（本地页面）

## 计划新特性支持

- 抓取数据，通过代理，筛选数据，保存数据。
- 完成演示爬虫数据数据流演示。
- 解析所需的数据
- 多实例运行，独立Cookie机制

## 贡献代码

> 如果需要使用或修改此项目的源代码，建议先Fork。也欢迎将您修改的通用版本Pull Request过来。

1. Fork
2. 创建您的特性分支 (`git checkout -b my-new-feature`)
3. 提交您的改动 (`git commit -am 'Added some feature'`)
4. 将您的修改记录提交到远程 `git` 仓库 (`git push origin my-new-feature`)
5. 然后到 github 网站的该 `git` 远程仓库的 `my-new-feature` 分支下发起 Pull Request

## 热键

热键 | 功能
------------ | -------------
Ctrl+T		| 新建一个选项卡
Ctrl+N		| 新建一个窗体
Ctrl+W		| 关闭当前活动选项卡
F5			| 刷新当前活动选项卡
F12			| 打开开发者工具
Ctrl+Tab	| 切换下一个（右）选项卡
Ctrl+Shift+Tab	| 切换上一个（左）选项卡
Ctrl+F		| 打开搜索栏(回车选择下一个,ECS键退出)

## 代码环境说明

- CefSpider 使用的是 CefSharp 51, NET Framework 4.5.2
- `MainForm.cs` - 主网页显示界面和功能代码
- `Handlers` -各种Handlers(句柄)的注册都是可以基于它进行处理，它是我们这个项目和CefSharp之间的桥梁
- `Data/JSON.cs` - 快速的Json序列号和反序列化操作
- `bin` - 二进制文件是包含在`bin`下，由于复杂的cefsharp安装所需要的文件夹，不要清空这个文件夹
- `bin/storage` - HTML 和 JS 为下载管理器和自定义错误页面所需

## 使用运行示例

- 配置运行代理示意图][videos/配置代理.mp4)]

<video src="https://raw.githubusercontent.com/robyle/CefSpider/master/videos/配置代理.mp4" controls="controls">
</video>

## 感谢声望

- [Robin Rodricks](https://github.com/robinrodricks) - CefSpider 项目.
- [Alex Maitland](https://github.com/amaitland) - CefSharp 项目, CEF嵌入浏览器的包装.

## 项目运行截图

### GitHub首页

![](https://raw.githubusercontent.com/robyle/CefSpider/master/images/Github.png)

### 百度地图

![](https://raw.githubusercontent.com/robyle/CefSpider/master/images/baiduMap.png)

### 搜索栏展示

![](https://raw.githubusercontent.com/robyle/CefSpider/master/images/search.png)

### 下载页面显示

![](https://raw.githubusercontent.com/robyle/CefSpider/master/images/FileNotFound.png)

### 开发者调试工具

![](https://raw.githubusercontent.com/robyle/CefSpider/master/images/DevTools.png)

### 自定义错误页面

![](https://raw.githubusercontent.com/robyle/CefSpider/master/images/cantConnect.png)

![](https://raw.githubusercontent.com/robyle/CefSpider/master/images/FileNotFound.png)

## 计划新增特性

- 扩展代理功能，代码和界面上都能调配Http代理。
- 新增设置选项
- 扩展任务栏状态：1.IP地址信息,网络状态 2.实时内核加载网速
- 支持Mp4,Mp3播放视频
