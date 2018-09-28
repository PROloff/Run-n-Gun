import Phaser from 'phaser-ce';
import Piteroid from '../sprites/Piteroid';
import Ship from '../sprites/Ship';

export default class extends Phaser.State {

  create () {
    this.gameOver = this.add.text(0, 40, 'Game Over');
    this.gameOver.font = 'Bangers';
    this.gameOver.padding.set(10, 16);
    this.gameOver.fontSize = 100;
    this.gameOver.fill = '#DF1D28';
    this.gameOver.smoothed = false;
    this.gameOver.anchor.setTo(0.5);

    this.resize();
  }

  resize() {
    this.gameOver.x = this.world.centerX;
    this.gameOver.y = this.world.centerY;
  }
}
