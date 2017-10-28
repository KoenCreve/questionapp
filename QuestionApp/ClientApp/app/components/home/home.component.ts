import { Component } from '@angular/core';

@Component({
    selector: 'home',
    templateUrl: './home.component.html',
     styleUrls: ['./home.component.css']
})
export class HomeComponent {
    show = true;

    toggleShow() {
        this.show = !this.show;
        let i = 0;
        console.log(i++);
    }
}
