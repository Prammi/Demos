
import {compute } from  './compute';

fdescribe('compute',()=>{
it('should return postive',()=>{
    const _pos=compute(1);
    expect(_pos).toBe("positive");
});
it('should return negative',()=>{
    const _pos=compute(-1);
    expect(_pos).toBe("negative");
})


});