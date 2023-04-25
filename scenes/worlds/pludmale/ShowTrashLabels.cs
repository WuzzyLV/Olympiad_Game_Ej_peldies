using Godot;
using System;

public class ShowTrashLabels : Godot.Label
{

    public void _on_Area2D_body_entered(object body)
    {
        if (body is Player)
        {
            this.Visible = true;
        }
    }
    public void _on_Area2D_body_exited(object body)
    {
        if (body is Player)
        {
            this.Visible = false;
        }
    }

}
