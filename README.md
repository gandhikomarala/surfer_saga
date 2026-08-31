# METRO RUSH: NEON ESCAPE — Enterprise Endless Runner Platform

Metro Rush: Neon Escape is an original, fast-paced 3D endless runner set across futuristic metro networks, city rooftops, underground maglev stations, and industrial rail corridors.

---

## 🌆 Architecture Overview

```
MetroRush/
├── UnityClient/            # Unity C# Client Architecture
│   └── Assets/Scripts/     # Core, Player, Movement, World, Trains, Obstacles, PowerUps, Drones, UI, Audio
├── Backend/                # Python FastAPI Distributed Backend Services
│   ├── app/                # API Endpoints, Models, Repositories, Analytics, NVIDIA Gateway
│   └── tests/              # Pytest automated test matrix (180 tests)
├── Infrastructure/         # Docker Compose, PostgreSQL configurations
├── docs/                   # Architecture, Game Design, API & Deployment Specifications
├── scripts/                # Standalone demo runner & diagnostic probes
└── index.html              # Standalone 3D WebGL Playable Edition
```

---

## 🚀 Quick Start

### 1. Run the Standalone Game Probe
```bash
python scripts/demo_run.py
```

### 2. Play the 3D Web Game
Open `index.html` directly in your browser or serve with:
```bash
python -m http.server 8000
```

### 3. Run Backend Test Matrix
```bash
pytest Backend/tests/ -v
```
