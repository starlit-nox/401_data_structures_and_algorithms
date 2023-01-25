'use strict';

class Navigator {
  constructor() {
    this.history = [];
    this.current_url = null;
    this.future = [];
  }

  go(url) {
    if (this.current_url) this.history.push(this.current_url);
    if (this.future.length) this.future = [];
    this.current_url = url;
  }

  back() {
    if (this.current_url) this.future.push(this.current_url);
    if (this.history.length) this.current_url = this.history.pop();
  }

  forward() {
    if (this.current_url) this.history.push(this.current_url);
    this.current_url = this.future.pop();
  }
}

module.exports = Navigator;
