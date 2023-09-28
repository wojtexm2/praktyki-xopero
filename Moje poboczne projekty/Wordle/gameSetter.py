import pygameHat as hat
from tiles import TileSet
from settings import Settings

class GameSetter(hat.Object):
    def __init__(self, word, numberOfAttempts):
        super().__init__()
        self._NUMBER_OF_ATTEMPTS = numberOfAttempts
        self._tilesets = [TileSet(word.upper()) for x in range(self._NUMBER_OF_ATTEMPTS)]
        self._pointer = 0
    
    def on_create(self):
        for number, set in enumerate(self._tilesets):
            ypos = number*(set.tile_size+Settings.tile_spacing)
            hat.add_object_instance(set, "default", (self.x, self.y+ypos))
    
    def add_letter(self, letter):
        if self._pointer == len(self._tilesets):
            hat.send_signal("LOST")
        if self._pointer < len(self._tilesets) and self._tilesets[self._pointer].add_letter(letter):
            verification = self._tilesets[self._pointer].verify()
            self._pointer += 1 
            return verification
        return False