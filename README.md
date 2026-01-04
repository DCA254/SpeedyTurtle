# 🐢 SpeedyTurtle

**SpeedyTurtle** is an **experimental / meme web browser** built in **C# using Windows Forms**, powered by **Microsoft WebView2 (Chromium)**.

> ⚠️ **This is NOT a browser for daily use.**
> This project exists for learning, experimentation, and because I was bored.

> 🚧 **Status: Finished / Not maintained.**

> **Important context:**
> This is my **first real project in C#**, so the code structure, patterns, and architecture are **very likely suboptimal, messy, or naïve**.

---

## Features

* Simple **WinForms-based UI**
* **Chromium engine** via **Microsoft WebView2**
* Address bar with:
  * Valid URL detection
  * Automatic search when the input is not a URL
* **Configurable search engine system**
* **JSON-based configuration system**
* **Visual highlighting** for valid / invalid links
* Internal settings page (**More Information Page**)
* Primitive NSFW keyword detection (meme feature)

---

## Technical Stack

* **Language:** C#
* **UI Framework:** Windows Forms
* **Runtime:** .NET **10.0 (Windows)**
* **Browser Engine:** Microsoft WebView2 (Chromium)
* **Platform:** Windows

---

## Supported Search Engines

Includes real engines **and meme engines**:

### Main engines

* Google
* Bing
* DuckDuckGo
* Brave
* Yahoo
* Ecosia
* Baidu
* Yandex

### Extras / Meme engines

* StackOverflow
* Reddit
* Wikipedia
* Steam
* Epic Games
* TikTok
* Roblox
* Fortnite
* Genshin Impact
* League of Legends
* IRS
* Brazil
* and more

> The full list is defined in `SearchEngine.cs`.

---

## Configuration System

SpeedyTurtle uses a **very simple JSON-based configuration system**.
This is **NOT a real API** — it’s just a lightweight config loader/saver.

Understanding how it works is important if you want to edit things manually.

---

## 📁 Configuration File Location

### Windows

```
%LOCALAPPDATA%/SpeedyTurtle/config.json
```

---

## How Configuration Actually Works

### 1. First Run (No config file exists)

* The program **creates the file path**
* **NO values are written to disk**
* The browser runs using **internal default values**
* Defaults are used **in memory only**

Result:
File exists (or path exists), but **empty or not written**, defaults are used.

---

### 2. Config File Exists (Even if empty)

* The application attempts to **load values from the file**
* If values are missing or invalid:

  * **Internal defaults are used as fallback**
* Defaults are still **NOT automatically written**

Result:
Config file is respected, but missing fields don’t break the app.

---

### Clicking **Apply Config**

* This is the **ONLY moment** where:

  * Configuration values are **written to `config.json`**
* Whatever is currently selected in the UI:

  * Gets serialized
  * Gets saved to disk

**No Apply click = no config saved**

This is intentional (even if not ideal).

---

## Example `config.json` Structure

```json
{
  "searchEngine": "Duck Duck Go",
  "homePageURL": "about:blank",
  "highlightLink": true,
  "validLinkHighlightColor": "LightGreen",
  "invalidLinkHighlightColor": "Yellow"
}
```

---

## “Configuration API” (Not Really an API)

Calling this an **API is generous**.

What it actually is:

* A **JSON schema implicitly defined by code**
* Parsed manually by `SpeedyTurtleConfigManager.cs`
* No validation layer
* No versioning
* No guarantees

### How it works internally

* Reads `config.json`
* Maps known keys to internal variables
* Ignores unknown keys
* Falls back to defaults when something is missing or invalid

### Manual Editing

If you want to edit the file manually:

* Keep valid JSON
* Use correct key names
* Use valid enum/string values (especially for colors & engines)

The program will NOT:

* Auto-fix broken JSON
* Write missing values for you
* Warn you if you mess it up

This is a **deliberately simple and fragile system**, suitable only for learning.

---

## Running the Project

### Requirements

* Windows 10 or newer
* .NET SDK 10.0
* Microsoft Edge WebView2 Runtime installed

---

### Build and Run

1. Clone the repo
```bash
$ git clone https://github.com/DCA254/SpeedyTurtle.git
```
2. Enter the source directory
```bash
$ cd SpeedyTurtle/src
```

### Build

```bash
$ dotnet build
```

### Run

```bash
$ dotnet run
```

---

## Project Structure (simplified)

```
SpeedyTurtle/src/
├─ Assets/                  # Icons, images and visual assets
├─ Browser.cs               # Main browser logic
├─ PageLinkHandler.cs       # Navigation, validation and link handling
├─ SearchEngine.cs          # Search engine system
├─ SpeedyTurtleConfigManager.cs
├─ MoreInformationPage.cs   # Settings page
├─ Program.cs               # Entry point
└─ SpeedyTurtle.csproj
```

---

## Project Goal

* Learn **C#** from scratch
* Study **Windows Forms**
* Explore **Microsoft WebView2**
* Experiment with basic browser UX (most basic UI and UX possible)
* Personal / educational project
* Intentionally non-serious meme browser

---

## ⚠️ Platform Support

This browser is currently **Windows-only**
because it is based on **Microsoft WebView2**.

**Reason:** I’m a dumbass and thought it could be multiplatform.

A **true cross-platform version using CEF** is planned as a **separate project**.

---

## Known Limitations

* Windows-only
* Poor architecture
* No advanced sandboxing
* No extension system
* No real security focus
* Extremely primitive NSFW detection (intentional because I'm lazy)
* Configuration system is fragile by design

---

## Inspiration

Inspired by the browser created by **Face-hh** in the video:

*  *I built my own Browser*
  [https://www.youtube.com/watch?v=37ISfJ2NSXQ](https://www.youtube.com/watch?v=37ISfJ2NSXQ)

Also check his:

* GitHub: [https://github.com/face-hh](https://github.com/face-hh)
* YouTube: [https://www.youtube.com/FaceDevStuff](https://www.youtube.com/FaceDevStuff)

---

## LICENSE

**MIT License**

---