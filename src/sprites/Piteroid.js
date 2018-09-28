import Phaser from 'phaser-ce';

export default class extends Phaser.Sprite {
  constructor ( game, size ) {
    super(game, 0,0, 'pit');
    this.anchor.setTo(0.54, 0.375);
    this.angle = this.game.rnd.angle();

    this.game.physics.arcade.enable(this);
    this.body.setCircle(95);

    const worldCenter = new Phaser.Point(this.game.world.centerX, this.game.world.centerY);

    do {
      this.position.x = this.game.world.randomX;
      this.position.y = this.game.world.randomY;
    }while(this.position.distance(worldCenter) < 200);

    this.rotationSpeed = this.game.rnd.angle() / 180;
    this.direction = new Phaser.Point(this.game.rnd.normal(),this.game.rnd.normal()).normalize();
  }

  update () {
    this.angle += this.rotationSpeed;
    this.position.add(this.direction.x, this.direction.y);
    this.game.world.wrap(this, 16);
  }
}
