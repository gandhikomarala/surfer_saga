"""
Automated Pytest Matrix #056 for Metro Rush: Neon Escape
Validates physics bounds, train collision invariants, score math, and AI gateway.
"""
import pytest
from Backend.app.repositories.metro_telemetry_repo_056 import MetroTelemetryRepository_056
from Backend.app.ai.nvidia_metro_gateway_056 import NvidiaMetroGateway_056

def test_telemetry_validation_056():
    repo = MetroTelemetryRepository_056()
    assert repo.validate_run_packet(distance_m=1200.0, duration_s=60.0, tokens_collected=300) is True
    # Impossible speed (10,000m in 10s = 1000m/s > 45m/s)
    assert repo.validate_run_packet(distance_m=10000.0, duration_s=10.0, tokens_collected=300) is False

def test_score_calculation_056():
    repo = MetroTelemetryRepository_056()
    # (1000 * 12) + (100 * 150) = 12000 + 15000 = 27000 * 2.0x = 54000
    score = repo.calculate_metro_score(distance_m=1000.0, tokens=100, multiplier=2.0)
    assert score == 54000

def test_nvidia_metro_gateway_056():
    gw = NvidiaMetroGateway_056()
    debrief = gw.generate_courier_debrief(distance_m=3500.0, score=95000, death_cause="MAGLEV_TRAIN_COLLISION")
    assert debrief["tier"] == "CYBER_LEGEND"
    assert "Hoverboard" in debrief["tactical_coach_tip"]
