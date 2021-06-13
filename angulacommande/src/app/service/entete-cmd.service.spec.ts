import { TestBed } from '@angular/core/testing';

import { EnteteCmdService } from './entete-cmd.service';

describe('EnteteCmdService', () => {
  let service: EnteteCmdService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(EnteteCmdService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
