import pygameHat as hat
from settings import Settings

class TileSet(hat.Object):
    def __init__(self, correct_text):
        super().__init__()
        self._CORRECT_TEXT = correct_text
        self.text = ""

        self._sprite_normal = hat.Sprite("assets/tile.png")
        self._tile_size = self._sprite_normal.x_size

        self._texturing = [self._sprite_normal for _ in self._CORRECT_TEXT]

    def on_create(self):
        self._sprite_normal = hat.Sprite("assets/tile.png")
        self._sprite_none = hat.Sprite("assets/tile_none.png")
        self._sprite_in = hat.Sprite("assets/tile_in.png")
        self._sprite_in_place = hat.Sprite("assets/tile_in_place.png")
        self._font = hat.Font(int(self._tile_size))
    
    def draw(self):
        for number in range(len(self._CORRECT_TEXT)):
            letter = self.text[number] if number < len(self.text) else ""
           
            posx = self.x+number*(self._tile_size+Settings.tile_spacing)
            letterx = posx+self._tile_size/2-self._font.measure_size(letter)[0]/2

            hat.draw_sprite(self._texturing[number], posx, self.y)
            hat.draw_font((letterx, self.y+self._tile_size/2-self._font.measure_size(letter)[1]/2), self._font, letter)
    
    @property
    def tile_size(self):
        return self._tile_size
    
    def add_letter(self, letter):
        self.text += letter
        if len(self.text) == len(self._CORRECT_TEXT):
            return True
        else:
            return False
    
    def verify(self):
        guessed = ""
        yellowed = ""
        redundant = ""
        if self.text == self._CORRECT_TEXT:
            hat.send_signal("WIN")

        for i, value in enumerate(self.text):
            if value == self._CORRECT_TEXT[i]:
                guessed += value
                self._texturing[i] = self._sprite_in_place
            elif value not in self._CORRECT_TEXT:
                self._texturing[i] = self._sprite_none
                redundant += value
        
        for i, value in enumerate(self.text):
            if value in self._CORRECT_TEXT and guessed.count(value) < self._CORRECT_TEXT.count(value) and yellowed.count(value) < self._CORRECT_TEXT.count(value) and self._texturing[i] != self._sprite_in_place:
                yellowed += value
                self._texturing[i] = self._sprite_in
        
        return guessed, yellowed, redundant