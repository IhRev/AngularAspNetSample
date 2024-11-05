import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { GroupsService } from './groups/groups.service';
import { StudentsService } from './students-tab/students-tab.service';

@NgModule({
  declarations: [],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [GroupsService, StudentsService],
  bootstrap: [AppComponent]
})
export class AppModule { }
