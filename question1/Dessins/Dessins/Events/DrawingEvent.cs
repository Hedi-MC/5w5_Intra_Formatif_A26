using Dessins.Controllers;
using System.Text.Json.Serialization;

namespace Dessins.Events
{
    [JsonDerivedType(typeof(DrawSquare))]
    [JsonDerivedType(typeof(DrawCircle))]
    [JsonDerivedType(typeof(DrawStar))]
    [JsonDerivedType(typeof(Wait))]
    [JsonDerivedType(typeof(ChangeColor))]
    [JsonDerivedType(typeof(StartDrawing))]
    public abstract class DrawingEvent
    {
        public abstract string Type { get; }

        public List<DrawingEvent>? DrawingEvents { get; set; } = null;
    }
}
