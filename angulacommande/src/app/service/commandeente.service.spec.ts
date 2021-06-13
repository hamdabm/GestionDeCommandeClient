import { TestBed } from '@angular/core/testing';

import { CommandeenteService } from './commandeente.service';

describe('CommandeenteService', () => {
  let service: CommandeenteService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CommandeenteService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
