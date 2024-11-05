import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Student } from '../students-tab/student-tab.model'
import { StudentsService } from './students-tab.service';
import { StudentComponent } from './student/student.component';

@Component({
  selector: 'app-students-tab',
  imports: [CommonModule, StudentComponent],
  standalone: true,
  templateUrl: './students-tab.component.html',
  styleUrl: './students-tab.component.css'
})

export class StudentsTabComponent implements OnInit {
  public students: Student[] = [];

  constructor(private studentsService: StudentsService) { }
    ngOnInit() {
      this.studentsService.students$.subscribe(students => this.students = students);
    }
}
