import { Component } from '@angular/core';
import { ContactsService } from './services/contacts.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'portifolio-web';

  name!: string;
  email!: string;
  subject!: string;
  message!: string;

  constructor(
    private contactService: ContactsService,
    private toastrService: ToastrService
  ) { }
  
  sendMessage() {
    console.log(this.name)
    this.contactService.addContact({
      Name: this.name,
      Email: this.email,
      Subject: this.subject,
      Message: this.message,
    }).subscribe(() => {
      this.toastrService.success('Mensagem enviada', 'Sucesso!');
      this.name = ""
      this.email = ""
      this.subject = ""
      this.message = ""
    })
  }
}
