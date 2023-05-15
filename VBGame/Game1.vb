Imports System
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Graphics
Imports Microsoft.Xna.Framework.Input

Namespace VBGame
    Public Class Game1
        Inherits Microsoft.Xna.Framework.Game

        Public Sub New()
            gdm = New GraphicsDeviceManager(Me)

            Content.RootDirectory = "Content"

            gdm.SynchronizeWithVerticalRetrace = True

            Window.AllowUserResizing = False
            IsMouseVisible = False

            gdm.IsFullScreen = False

        End Sub

        Protected Overrides Sub Initialize()
            MyBase.Initialize()
        End Sub

        Protected Overrides Sub LoadContent()
            SB = New SpriteBatch(GraphicsDevice)
        End Sub

        Protected Overrides Sub UnloadContent()

        End Sub

        Protected Overrides Sub Update(ByVal gameTime As GameTime)

        End Sub

        Protected Overrides Sub Draw(gameTime As GameTime)
            GraphicsDevice.Clear(Color.CornflowerBlue)

        End Sub
    End Class
End Namespace