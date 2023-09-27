import pygameHat as hat
from settings import Settings

class LetterButton(hat.Object):
    def __init__(self, key, rowsetter):
        super().__init__()
        self._key = key
        self.sprite = hat.Sprite("assets/tile.png", collision=True)
        self._sprite_inactive = hat.Sprite("assets/tile_none.png", collision=True)
        self._sprite_active = self.sprite
        self._rowsetter = rowsetter
        self._font = hat.Font(int(self.sprite.x_size)) 

        self._hovering = False
    
    def step(self):
        if hat.collide_mouse(self):
            self._hovering = True
        else:
            self._hovering = False
    
    def key_just_pressed(self, key):
        if key == 1 and self._hovering or ord(self._key.lower()) == key:
            self._rowsetter.add_letter(self._key)
    
    def draw(self):
        tile_size = self.sprite.x_size
        char_sizes = self._font.measure_size(self._key)
        char_x_size = char_sizes[0]
        char_y_size = char_sizes[1]
        hat.draw_sprite(self.sprite, self.x, self.y)
        hat.draw_font((self.x+tile_size/2-char_x_size/2, self.y+tile_size/2-char_y_size/2), self._font, self._key)

class Keyboard(hat.Object):
    def __init__(self, rowsetter):
        super().__init__()
        self.keys = []
        self.rowsetter = rowsetter

    def on_create(self):
        width = 60
        spacing = width+Settings.tile_spacing

        i2 = 0
        for i, char in enumerate("QWERTYUIOPASDFGHJKLZXCVBNM"):
            self.keys.append(hat.add_object_instance(LetterButton(char, self.rowsetter), "default", (self.x+i*spacing, self.y+i2*spacing)))
            if i % 5 == 0:
                i2 += spacing