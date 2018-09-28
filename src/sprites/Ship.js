import Phaser from 'phaser-ce';

export default class extends Phaser.Sprite {
  constructor ( game ) {
    super(game, 0, 0, 'ship');
    this.anchor.setTo(0.5, 0.5);

    this.game.physics.arcade.enable(this);
    this.body.drag.set(70);
    this.body.maxVelocity.set(200);

    this.angle = -90;

    this.weapon = game.add.weapon(40, 'bullet');      
    this.weapon.setBulletFrames(0, 80, true);    
    this.weapon.bulletKillType = Phaser.Weapon.KILL_WORLD_BOUNDS;
    this.weapon.bulletSpeed = 400;
    this.weapon.fireRate = 200;

    this.weapon.trackSprite(this, 0, 0, true);

    this.cursors = this.game.input.keyboard.createCursorKeys();

    this.fireButton = this.game.input.keyboard.addKey(Phaser.KeyCode.SPACEBAR);

    this.emitter = game.add.emitter(this.game.world.centerX, this.game.world.centerY, 200);
    
    this.emitter.makeParticles('smoke');

    this.emitter.setRotation(0, 0);
    this.emitter.setAlpha(0.5, 0, 1000);
    this.emitter.setScale(0.5, 3, 0.5, 3, 4000, Phaser.Easing.Quintic.Out);
    this.emitter.gravity = 0;
  }

  get bullets() {
      return this.weapon.bullets;
  }

  update () {
      
    var px = (this.body.acceleration.x) * -1.5;
    var py = (this.body.acceleration.y) * -1.5;

    this.emitter.minParticleSpeed.set(px-20, py-20);
    this.emitter.maxParticleSpeed.set(px+20, py+20);

    this.emitter.emitX = this.x;
    this.emitter.emitY = this.y;

    if(this.body.acceleration.x != 0 || this.body.acceleration.y != 0)
    {
        this.emitter.start(true,1000,null, 1);
    }

    if (this.cursors.up.isDown)
    {
        this.game.physics.arcade.accelerationFromRotation(this.rotation, 300, this.body.acceleration);        
    }
    else
    {
        this.body.acceleration.set(0);
    }

    if (this.cursors.left.isDown)
    {
        this.body.angularVelocity = -300;
    }
    else if (this.cursors.right.isDown)
    {
        this.body.angularVelocity = 300;
    }
    else
    {
        this.body.angularVelocity = 0;
    }

    if (this.fireButton.isDown)
    {
        this.weapon.fire();
    }

    this.game.world.wrap(this, 16);
  }
}
