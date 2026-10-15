# Dream League Soccer 2026 (Prototype)

This repository contains playable HTML5 prototypes and a Unity project skeleton for a Dream League–style football game with time-of-day and match scheduling features.

Contents
- index.html — Playable HTML5 prototype (open in a modern browser).
- unity/Assets/Scripts — Unity C# scripts (TimeOfDayController, MatchScheduler, PlayerStats).
- backend/ — Example stub docs for PlayFab and Firebase integration.
- docs/GameDesignDoc.md — Game design and roadmap.

License: MIT

How to run the HTML prototype
1. Download or clone this repo.
2. Open index.html in a modern desktop browser (Chrome/Edge/Firefox). For local testing, you can also run a simple static server (recommended) such as:

   ```bash
   # Python 3
   python -m http.server 8000
   # then open http://localhost:8000
   ```

Unity skeleton
- The `unity/` folder contains scripts and instructions to create a Unity project for WebGL/Android.
- Import the scripts into a Unity project (recommended Unity 2021.3 LTS or later).

Next steps
- If you want, I can push a Unity scene and package (small placeholders) or wire PlayFab auth and a basic leaderboard.

