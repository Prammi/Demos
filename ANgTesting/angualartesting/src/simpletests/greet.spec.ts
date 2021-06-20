import {greet } from  './greet';

fdescribe('greet',()=>{
it('should return name',()=>{
    const _pos=greet("Name");
    console.log("Name");
    expect(_pos).toContain("Name");
});



});