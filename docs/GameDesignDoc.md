# Game Design Document — Football Prototype (short)

Overview
- Title: Dream League Soccer 2026 (prototype: FC PITCH)
- Genre: Arcade football / simple management
- Platforms: Web (HTML5), target Unity WebGL + Android

Core Features
- 5v5 or 11v11 simplified matches
- Player control (WASD), kick, sprint, switch players
- Team selection, basic AI, scoring, timer
- Time-of-day visuals: morning/afternoon/night, stadium lights
- Match scheduling: select hour, auto-cycle day/night

Progression & Modes (future)
- Career mode: fixtures, standings, cup competitions
- Team management: transfers, upgrades, cosmetic kits
- Monetization: IAP currency, season pass, rewarded ads

Backend & Live Ops
- Authentication: PlayFab or Firebase (stubs included)
- Leaderboards, matchmaking (PlayFab/Firebase recommended)

Roadmap (high-level)
- Week 0–2: Prototype polish, UI, sound, small art pack
- Week 3–6: Unity port, match systems, persistence
- Week 7–12: Career mode, monetization integration, analytics
- Week 13–20: Multiplayer/matchmaking, live ops framework

Files in repo
- index.html — playable prototype
- unity/Assets/Scripts — example C# scripts
- backend/ — integration stubs
- docs/ — this design doc

