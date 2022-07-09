import { Component } from '@angular/core';

@Component({
  selector: 'app-counter-component',
  AnagramsUrl: './counter.component.html'
})
export class CounterComponent {
  public currentCount = 0;

  public incrementCounter() {
    this.currentCount++;
  }
}
