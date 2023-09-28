import pygameHat as hat
from settings import Settings

class LetterButton(hat.Object):
    def __init__(self, key, rowsetter):
        super().__init__()
        self._key = key
        self.sprite = hat.Sprite("assets/tile.png", collision=True)
        self._sprite_inactive = hat.Sprite("assets/tile_none.png", collision=True)
        self._sprite_in = hat.Sprite("assets/tile_in.png", collision=True)
        self._sprite_in_place = hat.Sprite("assets/tile_in_place.png", collision=True)
        self._sprite_active = self.sprite
        self._rowsetter = rowsetter
        self._font = hat.Font(int(self.sprite.x_size)) 
        self.tags = ["key"]

        self._hovering = False
    
    def step(self):
        if hat.collide_mouse(self):
            self._hovering = True
        else:
            self._hovering = False
    
    def key_just_pressed(self, key):
        if key == 1 and self._hovering or ord(self._key.lower()) == key:
            verification = self._rowsetter.add_letter(self._key)
            if verification:
                for k in hat.find_objects_by_tags(["key"]):
                    k.recolor(verification)
   
    def recolor(self, verification):
        if self._key in verification[2] and self.sprite != self._sprite_in_place and self.sprite != self._sprite_in:
            self.sprite = self._sprite_inactive
        elif self._key in verification[1] and self.sprite != self._sprite_in_place:
            self.sprite = self._sprite_in
        elif self._key in verification[0] and self._key not in verification[1]:
            self.sprite = self._sprite_in_place
    
    def draw(self):
        tile_size = self.sprite.x_size
        char_sizes = self._font.measure_size(self._key)
        char_x_size = char_sizes[0]
        char_y_size = char_sizes[1]
        hat.draw_sprite(self.sprite, self.x, self.y)
        hat.draw_font((self.x+tile_size/2-char_x_size/2, self.y+tile_size/2-char_y_size/2), self._font, self._key)

class ActionButton(LetterButton):
    def __init__(self, title, rowsetter, number):
        super().__init__(title, rowsetter)
        self.tags = []
        self._number = number
    def key_just_pressed(self, key):
        if key == 1 and self._hovering or key == self._number:
            self._rowsetter.add_letter(self._key)

class Keyboard(hat.Object):
    def __init__(self, rowsetter):
        super().__init__()
        self._keys = []
        self._rowsetter = rowsetter
        self._characters = "QWERTYUIOPASDFGHJKLZXCVBNM"

    def on_create(self):
        width = 60
        spacing = width+Settings.tile_spacing

        r = 0
        c = 0
        rows = 4
        breakr = len(self._characters)//rows
        for char in self._characters:
            self._keys.append(hat.add_object_instance(LetterButton(char, self._rowsetter), "default", (self.x+(c*spacing), self.y+(r*spacing))))
            if (c < breakr):
                c += 1
            else:
                c = 0
                r += 1
        self._keys.append(hat.add_object_instance(ActionButton("DEL", self._rowsetter, 8), "default", (self.x+(c*spacing), self.y+(r*spacing))))