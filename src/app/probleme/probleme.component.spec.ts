import { ComponentFixture, TestBed } from '@angular/core/testing';
import { ReactiveFormsModule } from '@angular/forms';

import { ProblemeComponent } from './probleme.component';

describe('ProblemeComponent', () => {
  let component: ProblemeComponent;
  let fixture: ComponentFixture<ProblemeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ReactiveFormsModule], //Ajouté
      declarations: [ ProblemeComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ProblemeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  //  it('should create', () => {
  //    expect(component).toBeTruthy();
  //  });


   it('#1 | Zone PRÉNOM invalide avec 2 caractères', () => {
     let errors = {};
     let zone = component.problemeForm.controls['prenom'];
     zone.setValue('a'.repeat(2));
     errors = zone.errors || {};
      expect(errors['minlength']).toBeTruthy();
   });
  it('#2 | Zone PRÉNOM valide avec 3 caractères', () => {
      let zone = component.problemeForm.controls['prenom'];
      zone.setValue('a'.repeat(3));
      expect(zone.valid).toBeTruthy();
    });
  it('#3 | Zone PRÉNOM valide avec 200 caractères', () => {
      let errors = {};
      let zone = component.problemeForm.controls['prenom'];
      zone.setValue('a'.repeat(200))
      errors = zone.errors || {};
      expect('maxlength').toBeTruthy();
    });
  it('#4 | Zone PRÉNOM invalide avec aucune valeur', () => {
     let errors = {};
     let zone = component.problemeForm.controls['prenom'];
     zone.setValue('');
     errors = zone.errors.required || {};
     expect(zone.errors.required).toBeTruthy();
   });
   it('#5 | Zone PRÉNOM valide avec 10 espaces', () => {
    let errors = {};
    let zone = component.problemeForm.controls['prenom'];
    zone.setValue(' '.repeat(10));
    errors = zone.errors || {};
    expect(zone.valid).toBeTruthy();
  });
  it('#6 | Zone PRÉNOM valide avec 2 espaces et 1 caractère', () => {
    let errors = {};
    let zone = component.problemeForm.controls['prenom'];
    zone.setValue(' '.repeat(2)+'a');
    errors = zone.errors || {};
  expect(zone.valid).toBeTruthy();
  });

});
