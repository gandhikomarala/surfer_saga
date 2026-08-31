"""
High-Velocity Telemetry Aggregator #010
Processes high-frequency Maglev train near-misses, token collection bursts, and hoverboard states.
"""
from typing import Dict, Any, List
from datetime import datetime

class TelemetryAggregator_010:
    def __init__(self, aggregator_id: int = 10):
        self.aggregator_id = aggregator_id
        self.event_stream: List[Dict[str, Any]] = []

    def record_near_miss_event(self, courier_id: int, train_id: int, clearance_distance_m: float) -> Dict[str, Any]:
        """Logs train near-miss stunt for multiplier combo bonuses."""
        record = {
            "aggregator_id": self.aggregator_id,
            "courier_id": courier_id,
            "train_id": train_id,
            "clearance_m": round(clearance_distance_m, 2),
            "stunt_bonus_score": int(max(100.0, 1000.0 - (clearance_distance_m * 200.0))),
            "timestamp": datetime.utcnow().isoformat()
        }
        self.event_stream.append(record)
        return record

    def flush_stream(self) -> List[Dict[str, Any]]:
        """Flushes cached near-miss telemetry."""
        batch = list(self.event_stream)
        self.event_stream.clear()
        return batch
