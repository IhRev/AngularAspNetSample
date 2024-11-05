import { Component, EventEmitter, Input, Output } from '@angular/core';
import { Group } from '../groups.model'

@Component({
  selector: 'app-group',
  standalone: true,
  templateUrl: './group.component.html',
  styleUrl: './group.component.css'
})

export class GroupComponent {
  @Input() group!: Group;
  @Output() groupSelected = new EventEmitter<number>();

  onGroupSelected() {
    this.groupSelected.emit(this.group.id);
  }
}
