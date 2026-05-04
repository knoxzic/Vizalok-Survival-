using Sandbox;

namespace RustSolo
{
    public partial class PlayerController : AnimatedEntity
    {
        public override void Spawn()
        {
            base.Spawn();

            SetModel( "models/citizen/citizen.vmdl" );
            EnableDrawing = true;
            EnableHideInFirstPerson = true;
            EnableShadowInFirstPerson = true;
        }
    }
}
