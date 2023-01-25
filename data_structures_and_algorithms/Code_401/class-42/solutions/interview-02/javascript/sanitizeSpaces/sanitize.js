'use strict';

function sanitize(string) {
  let sanitized = '';

  for (let i = 0; i < string.length; i++) {
    if (string.charCodeAt(i) == 32 || string[i] == ' ') {
      sanitized+= '%20';
    } else {
      sanitized+= string[i];
    }
  }

  return sanitized;
}

module.exports = sanitize;
