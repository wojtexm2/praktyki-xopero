import pygameHat as hat
from gameSetter import GameSetter
from word_keyboard import Keyboard
from ui import Wall
from random import choice

hat.Settings.shameless_ad = False
hat.Settings.enable_console = True
hat.Settings.window_title = "Wordle"
hat.Settings.icon = "assets/icon.png"
hat.Settings.window_size = (1600, 900)

hat.init()
hat.current_room.background = (255, 255, 255)

with open("lists/"+hat.saveManager.load("lists/select.json")["selected"], "r") as f:
    word_list = f.read().split("\n")

setter = GameSetter(choice(word_list), 6)


hat.add_object_instance(setter, "default", (5, 5))
hat.add_object_instance(Keyboard(setter), "default", (6, 500))
hat.add_object_instance(Wall(setter), "default")

hat.start()