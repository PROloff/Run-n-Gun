import Phaser from 'phaser-ce';
import Piteroid from '../sprites/Piteroid';
import Ship from '../sprites/Ship';

export default class extends Phaser.State {
  init () {}
  preload () {}

  create () {
    this.header = this.add.text(0, 40, 'PIT-Hackathon 2017');
    this.header.font = 'Bangers';
    this.header.padding.set(10, 16);
    this.header.fontSize = 100;
    this.header.fill = '#DF1D28';
    this.header.smoothed = false;
    this.header.anchor.setTo(0.5);

    this.ship = new Ship(this.game);
    this.game.add.existing(this.ship);
    this.ship.position.set(this.world.centerX, this.world.centerY);

    this.piteroids = this.game.add.group();
    for(let i=0;i<10;i++) {
      let piteroid = new Piteroid(this.game);
      this.piteroids.add(piteroid);
    }

    this.resize();
  }

  update() {
    this.game.physics.arcade.overlap(this.ship.bullets, this.piteroids, this.piteroidHit, null, this);

    if(this.piteroids.countLiving() == 0) {
      this.state.start('GameOver');
    }
  }

  piteroidHit (bullet, piteroid) {    
    bullet.kill();
    piteroid.kill();    
  }

  resize() {
    this.header.x = this.world.centerX;
    this.header.y = 40;
  }

  render () {}
}
