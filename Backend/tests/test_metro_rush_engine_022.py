"""
Automated Pytest Matrix #022 for Metro Rush: Neon Escape
Validates physics bounds, train collision invariants, score math, and AI gateway.
"""
import pytest
from Backend.app.repositories.metro_telemetry_repo_022 import MetroTelemetryRepository_022
from Backend.app.ai.nvidia_metro_gateway_022 import NvidiaMetroGateway_022

def test_telemetry_validation_022():
    repo = MetroTelemetryRepository_022()
    assert repo.validate_run_packet(distance_m=1200.0, duration_s=60.0, tokens_collected=300) is True
    # Impossible speed (10,000m in 10s = 1000m/s > 45m/s)
    assert repo.validate_run_packet(distance_m=10000.0, duration_s=10.0, tokens_collected=300) is False

def test_score_calculation_022():
    repo = MetroTelemetryRepository_022()
    # (1000 * 12) + (100 * 150) = 12000 + 15000 = 27000 * 2.0x = 54000
    score = repo.calculate_metro_score(distance_m=1000.0, tokens=100, multiplier=2.0)
    assert score == 54000

def test_nvidia_metro_gateway_022():
    gw = NvidiaMetroGateway_022()
    debrief = gw.generate_courier_debrief(distance_m=3500.0, score=95000, death_cause="MAGLEV_TRAIN_COLLISION")
    assert debrief["tier"] == "CYBER_LEGEND"
    assert "Hoverboard" in debrief["tactical_coach_tip"]
