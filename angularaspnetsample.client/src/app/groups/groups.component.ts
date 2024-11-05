import { Component, OnInit } from '@angular/core';
import { Group } from '../groups/groups.model'
import { GroupsService } from '../groups/groups.service'
import { StudentsService } from '../students-tab/students-tab.service'
import { GroupComponent } from '../groups/group/group.component'
import { CommonModule  } from "@angular/common"

@Component({
  imports: [GroupComponent, CommonModule],
  standalone: true,
  selector: 'app-groups',
  templateUrl: './groups.component.html',
  styleUrl: './groups.component.css'
})

export class GroupsComponent implements OnInit {
  public groups: Group[] = [];

  constructor(private readonly groupsService: GroupsService, private readonly studentsService: StudentsService) { }

  ngOnInit(): void {
    this.groupsService.getAllGroups().subscribe(
      (result) => this.groups = result,
      (error) => console.error(error)
    );
  }

  groupSelected(id: number) {
    this.studentsService.loadStudents(id);
  }
}
