import Preload from './classes/Preload';
import Game from "./classes/Game";
import { Phaser } from '../docs/main.02acc2be';

const config = {
  type: Phaser.AUTO,
  width: 1280,
  height: 960,
  physics: {
    default: 'arcade',
    arcade: {
      debug: true
    },
  },
  scene: [
    // Preload,
    Game
  ],
  pixelArt: true,
  roundPixels: true,
};

export default config;
