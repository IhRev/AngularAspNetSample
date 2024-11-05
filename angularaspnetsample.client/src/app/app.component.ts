import { Component } from '@angular/core';
import { GroupsComponent } from '../app/groups/groups.component';
import { StudentsTabComponent } from '../app/students-tab/students-tab.component';

@Component({
  imports: [GroupsComponent, StudentsTabComponent],
  standalone: true,
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})

export class AppComponent {
}
