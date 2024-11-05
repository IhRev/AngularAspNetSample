import { Component, Input } from '@angular/core';
import { Student } from '../student-tab.model'

@Component({
  selector: 'app-student',
  standalone: true,
  templateUrl: './student.component.html',
  styleUrl: './student.component.css'
})

export class StudentComponent {
  @Input() student!: Student;
}
