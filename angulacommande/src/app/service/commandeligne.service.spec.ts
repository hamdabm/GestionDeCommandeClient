import { TestBed } from '@angular/core/testing';

import { CommandeligneService } from './commandeligne.service';

describe('CommandeligneService', () => {
  let service: CommandeligneService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(CommandeligneService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
