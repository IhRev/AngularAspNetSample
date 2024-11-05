import { HttpClient } from '@angular/common/http'
import { GroupDTO } from '../groups/group.dto'
import { Group } from '../groups/groups.model'
import { Injectable } from '@angular/core';
import { map } from 'rxjs/operators';
import { Observable } from 'rxjs';

@Injectable()
export class GroupsService {
  constructor(private readonly client: HttpClient) { }

  public getAllGroups(): Observable<Group[]> {
    return this.client
      .get<GroupDTO[]>('https://localhost:7094/groups')
      .pipe(
        map((dtos: GroupDTO[]) => dtos.map(dto => new Group(dto.id, dto.name)))
      );
  }
}
