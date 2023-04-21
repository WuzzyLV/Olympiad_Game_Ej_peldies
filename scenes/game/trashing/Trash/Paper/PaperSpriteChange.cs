using Godot;
using System;

public class PaperSpriteChange : Sprite
{
    private Texture[] textures;


    public override void _Ready()
    {

        textures = new Texture[] {
            (Texture)ResourceLoader.Load("res://assets/trash/Paper/Books.png"),
            (Texture)ResourceLoader.Load("res://assets/trash/Paper/CardboardBox.png"),
            (Texture)ResourceLoader.Load("res://assets/trash/Paper/Paper.png")
        };


        SetRandomTexture();
    }



    private void SetRandomTexture()
    {
        var randomIndex = new Random().Next(0, textures.Length);
        Texture = textures[randomIndex];
    }
}
