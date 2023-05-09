using BikeService.Enums;

namespace BikeService.Models;

public record ServiceEvent(ServiceEventType Type, DateTime Start, DateTime End, int Price, List<Part> PartsNeeded, List<Tool> ToolsNeeded);