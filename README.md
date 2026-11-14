# PCL-CE 解限版

**简体中文** | [English](README-EN.md) | [繁體中文](README-ZH_TW.md)

<div align="center">

<img src="Plain Craft Launcher 2/Images/icon.ico" alt="Logo" width="80" height="80">

基于 [PCL Community Edition](https://github.com/PCL-Community/PCL-CE) 的修改版本 —— **解限版**，移除了原版中的地区下载限制。

[![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://get.dot.net/10)
[![Platform](https://img.shields.io/badge/platform-Windows%2010%2B-0078D4?style=for-the-badge&logo=windows&logoColor=white)](https://github.com/wutong0850/pcl-ce-解限版)
[![License](https://img.shields.io/badge/license-Apache%202.0%20%2F%20Custom-4EAA25?style=for-the-badge&logo=opensourceinitiative&logoColor=white)](#许可证)

</div>

PCL CE 是基于 PCL 开源代码二次开发的社区版本，本仓库在其基础上移除了地区下载限制，使得 Minecraft 本体下载、缺失文件补全、整合包安装等原本受地区限制的功能可以正常使用。

> ⚠️ **与原版的关系**：本仓库是 PCL-Community/PCL-CE 的修改版，版本号与原版并非严格对应，请勿向[原版仓库](https://github.com/PCL-Community/PCL-CE/issues/new/choose)反馈本版本的问题。

**开发群:** [599620549](https://qm.qq.com/q/PNQA4Md8wc) | **用户 1 群:** [1028074835](https://qm.qq.com/q/qrMGJo8BQQ) | **用户 2 群:** [1070029541](https://qm.qq.com/q/lBywbDMWhG)

## 核心改动

| 改动 | 说明 |
|---|---|
| 🔓 移除地区下载限制 | 修改 `RestrictedFeaturePolicy.cs`，解除 Minecraft 本体下载、缺失文件补全、整合包安装等功能的地区限制判定 |
| 🛠 适配 .NET 10 | 将各子项目的 `LangVersion` 统一调整为 `latest`，以适配 .NET 10 SDK 编译器 |

## 下载与安装

前往 [Releases](https://github.com/wutong0850/pcl-ce-解限版/releases/latest) 下载最新版本的 `Plain Craft Launcher 2.exe`。

- 自包含版本：双击即可运行，无需安装 .NET 运行时
- 框架依赖版本：需要先在系统上安装 [.NET 10 Desktop Runtime](https://get.dot.net/10)

## 快速构建
