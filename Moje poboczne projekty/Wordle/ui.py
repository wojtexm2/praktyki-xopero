import pygameHat as hat

class Wall(hat.Object):
    def __init__(self, gameSetter):
        super().__init__()
        self.sprite = hat.Sprite("assets/whiter.png")
        self.sprite.set_alpha(200)
        self.text = "YOU WIN!"
        self.visible = False
        self._font = hat.Font(50, color = (0, 0, 0))
        self._gameSetter = gameSetter
    
    def on_signal(self, signal):
        if signal == "WIN":
            self.visible = True
        elif signal == "LOST" and not self.visible:
            self.visible = True
            self.text = "YOU LOSE! The word was: "+self._gameSetter.word
    
    def draw(self):
        hat.draw_sprite(self.sprite, self.x, self.y)
        hat.draw_font((self.x+200, self.y+200), self._font, self.text)