using Dessins.Events;
using Microsoft.AspNetCore.Mvc;

namespace Dessins.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class DessinsController : ControllerBase
    {
        [HttpGet]
        // Rien à modifier ici, juste un exemple de dessin très simple
        public ActionResult GetDrawing1()
        {
            var drawSquare = new DrawSquare(2, 2);
            
            return Ok(drawSquare);
        }

        // TODO: Il faut ajouter une nouvelle action pour dessiner la séquence mentionnée dans l'énoncé
        [HttpGet]
        public ActionResult GetDrawing2()
        {
           

            var root = new StartDrawing();

            root.DrawingEvents.Add(new DrawCircle(1, 1));
            root.DrawingEvents.Add(new Wait(3));

            root.DrawingEvents.Add(new ChangeColor("red"));
            root.DrawingEvents.Add(new DrawSquare(0, 2));
            root.DrawingEvents.Add(new DrawSquare(2, 2));
            root.DrawingEvents.Add(new Wait(1));

            root.DrawingEvents.Add(new ChangeColor("yellow"));
            root.DrawingEvents.Add(new DrawStar(1, 3, 20));

            return Ok(root);
        }
    }
    public class StartDrawing : DrawingEvent
    {
        public override string Type { get { return "StartDrawing"; } }

        public StartDrawing()
        {
            DrawingEvents = new List<DrawingEvent>();
        }
    }
   

    
}
