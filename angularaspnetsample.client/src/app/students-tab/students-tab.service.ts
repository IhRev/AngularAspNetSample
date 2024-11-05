import { Injectable } from "@angular/core";
import { HttpClient } from "@angular/common/http"; 
import { StudentDTO } from "../students-tab/students-tab.dto";
import { Student } from "../students-tab/student-tab.model";
import { BehaviorSubject, map } from "rxjs";

@Injectable()
export class StudentsService {
  constructor(private httpClient: HttpClient) { }

  private students = new BehaviorSubject<Student[]>([]); 
  public students$ = this.students.asObservable();

  public loadStudents(groupId: number) {
    this.httpClient
      .get<StudentDTO[]>('https://localhost:7094/groups/' + groupId +'/students')
      .pipe(
        map((dtos: StudentDTO[]) => (
          dtos.map(
            dto => new Student(
              dto.id,
              dto.firstName,
              dto.lastName,
              dto.dateOfBirth,
              dto.groupId
            )
          )
        ))
      )
      .subscribe(
        (students) => this.students.next(students),
        (error) => console.error(error)
      );
  }
}
