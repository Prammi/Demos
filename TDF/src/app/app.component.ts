import { Component } from '@angular/core';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { User } from './user';
import { of, Observable } from 'rxjs';
import { filter, map } from 'rxjs/operators'; 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})

export class AppComponent {
  title = 'app';
  a:Observable<number>
/**
 *
 */

  // // ##Template Driven
  // topics = ["react", "angular", "type"];
  // userModel = new User('rob', 'rob@test.com', 123123123123, '', 'morning', true);
  // topicHasError = false;
  // validateTopic(topic) {
  //   if (topic == '') {
  //     this.topicHasError = true;
  //   }

  // }
  // onSubmit(){
  //   console.log(this.userModel);
  // }
    // // ##Template Driven End


    //===============================================Reactive=================

    constructor(private fb:FormBuilder) { 

    }
    registrationForm  = this.fb.group({
      userName: ['Pramod'],
      password:['']

    });

    LoadData(){
      // this.registrationForm.setValue({
      //   userName:'Pramod',password:'1234'
      // })
      //only some of the values not all using patch value
      this.registrationForm.patchValue({
        userName:'Pramod'
      })
    }

    //===============================================Reactive END=================
 


}
