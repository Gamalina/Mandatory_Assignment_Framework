# Work In Progress
# Mandatory Assignment Framework in Advanced Software Construction
Idea:
To define a Library with classes that together provide a mini framework for turn-based 2D
game by using different tools and techniques obtained throughout the course.
However, you should not support any GUI.

In this library you are to focused on creating a world with different creatures (of your
flavour), which could have different protection (shield, magic etc.) and different attack
possibilities (weapon, magic, army etc.).

The reason for having a 2D game is, that it is much easier to maintain, design and
implement. In addition, for the same reason you are to make a turn-based game.
Due to the topic during this course 'Advanced Software Construction' you are not to
implement nor consider any User Interface in the Framework.

Detailed description:

You must create a Library with classes, which together form a mini framework for a turn based 2D game where you have a World, Creatures and Objects (e.g. obstacles).
You must not make any written report. Comments in the code are welcome but no textdocument like a report.

Therefore, you are to make a Framework i.e. a library to support other game-designers doing Turn-based 2D games.
Your solution must be accessible from a GitHub-repository (or similar repositories).

The first step is to implement following elements (see also next page):
• A World (some 2D playground)
• Creatures (which have a position in the world)
• Objects (with a fixed position)
Some should be removable from the world and some could hold bonus or drawbacks
(new weapon, new shield, hit points, some anti-protection or ... )
• Attack objects (weapon, magic, ...)
• Defence objects (Shield, boots, ...)

Some functions
• A Creature can hit other creatures
• A Creature can pick objects (if the object can be picked), whereby the creature can
get weapon, shield, magic, hit points, or like.
• A Creature can receive hit and possible die if life-point are zero or below


Improve the framework:

You have done the initial work, where you have implemented the class diagram above i.e.
have implemented the classes simple and concrete.
Now you should refactor the framework step by step to be more and more flexible for
modifications and make use of the different techniques you have faced and will face during
this course.

• The framework must be configurable from a configuration-file (week 7)
• The framework must support tracing/logging messages (week 7)
• The framework must be documented i.e. ///-comments (week 5)
• The framework must follow the principles of SOLID (week 12)
• The framework make use of iterations and LINQ (week 15)

• At least three Design Pattern (week 5, 10, 13) e.g. among these:
o Template
o State
o Composite
o Observer
o Decorator
o Strategy
o Factory (Abstract Factory)

• Some nice features could be
o Reflection (week 11)
o Operator overload (week 15)
