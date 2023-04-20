using Godot;
using System;

public class PlasticSpriteChange : Sprite
{

    
    private Texture[] textures;

    
    public override void _Ready()
    {
       
        textures = new Texture[] {
            (Texture)ResourceLoader.Load("res://Trash/Plastic/BigBottle.png"),
            (Texture)ResourceLoader.Load("res://Trash/Plastic/PlasticUtensils.png"),
            (Texture)ResourceLoader.Load("res://Trash/Plastic/SmallBottle.png")
        };

       
        SetRandomTexture();
    }

    

    private void SetRandomTexture()
    {
        var randomIndex = new Random().Next(0, textures.Length);
        Texture = textures[randomIndex];
    }
}

