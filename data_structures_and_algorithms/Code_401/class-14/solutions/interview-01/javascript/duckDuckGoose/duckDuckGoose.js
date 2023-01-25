'use strict';

function duckDuckGoose(strings, k) {
  let queue = [];

  for (let string of strings) {
    queue.push(string);
  }

  while(queue.length > 1) {
    for (let i = 1; i <= k; i++) {
      let duck = queue.shift();
      let isNotGoose = Boolean(i !== k);

      if (isNotGoose) {
        queue.push(duck);
      }
    }
  }

  return queue[0];
}

module.exports = duckDuckGoose;
