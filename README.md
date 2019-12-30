# TicTcToeinc-
Using c# to develop simple game of Tic-Tac -Toe in windows Form

Tic-tac-toe (also known as noughts and crosses or Xs and Os) is a paper-and-pencil game for two players, X and O, 
who take turns marking the spaces in a 3×3 grid. 
The player who succeeds in placing three of their marks in a horizontal, vertical, or diagonal row wins the game.

Gameplay
Two players play. They have a symbol assigned to them; traditionally one gets X and the other gets O. One player starts, traditionally the X player. Each player, in turn, places their symbol on an empty square on a 3 \times 33×3 grid, trying to be the first one that creates a line of three of their symbols (either horizontal, vertical, or diagonal). The first one to do so wins; in case the grid is filled without any result, it is a draw.

Strategy
On playing tic-tac-toe, tactics and strategy are a must in order to win.

The simplest tactic is to complete a three-in-a-row: if you have two of your symbols lined up in a row (either horizontal, vertical, or diagonal) and the remaining square is empty, play on it, giving you the win. If you have two of your symbols lined up, and the last square is empty, this is called a threat.

The above tactic gives rise to blocking: if the opponent has two of their symbols lined up and the remaining square is empty, you must block it by playing on the last remaining square.

Given the blocking tactic, it's pretty natural to consider creating two different threats so that the opponent cannot block both at the same time. This is called a fork (as it has two (or more) directions, like a dining fork splitting from one handle to several tines; also compare with fork in chess, which is to make a threat in multiple directions).

Okay! Now it's time to play the game:

a
a
b
b
c
c
d
d
e
e
Either aa or bbEither bb or ee
Assume that you are playing a tic-tac-toe game with an opponent. You play as XX while your opponent plays as OO.

The game is played as follows:



Find all the possible grid tiles where you can put an XX-mark that will help you guarantee a win under best play.

A player can prevent the opponent from making a fork if he

places his mark on a grid tile where a fork can be made, or
forces the opponent by blocking his threat instead of making a fork, or
places at the center if vacant, which blocks most of the forks.
Lower-left cornerUpper-right cornerAny of the two cornersAny of the middle spaces on a sideEither middle space on the left or right sideEither middle space on the upper or lower side
You are playing a game of tic-tac-toe. You play as OO while your opponent plays as XX. The game plays as shown:



Where should you put your next OO in order to save yourself from losing?

YesNo


It's X's turn. Can O force a win?


Note: O and X are both playing optimally.

YesNo
If it's \color{#3D99F6}\text{O}O's turn, can \color{#3D99F6}\text{O}O force a win?



Let's play one more time:

OXCan't be determined

Two amateur people are playing a game of tic-tac-toe. Each person places his/her mark, either \color{#D61F06} XX or \color{#3D99F6}OO. We do not know who started first.

After the first player has placed his/her second mark, the players will always place his or her mark in a line that already contains

(a) two of his/her own marks,
(b) two of his/her opponent's marks,
(c) giving priority to (a) over (b).

Only the last mark to be placed in the game shown in the figure has not been given. Who will win the game, \color{#D61F06} XX or {\color{#3D99F6}O}?O?

1234Any place

Assume that you are playing a tic-tac-toe game with an opponent. You play as OO while your opponent plays as XX.

On which place should you place your next move so that you will lose the next turn regardless of where your opponent's next move is?

See Also
Combinatorial Games - Winning Positions

Nim

K-level Thinking

Cite as: Tic Tac Toe. Brilliant.org. Retrieved 07:16, December 30, 2019, from https://brilliant.org/wiki/tic-tac-toe/

