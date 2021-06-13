import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CommandeEnteteComponent } from './commande-entete.component';

describe('CommandeEnteteComponent', () => {
  let component: CommandeEnteteComponent;
  let fixture: ComponentFixture<CommandeEnteteComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CommandeEnteteComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CommandeEnteteComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
