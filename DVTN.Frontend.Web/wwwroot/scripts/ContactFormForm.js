import{d as h,o as r,c as a,a as e,t as u,n as f,w as i,v as n,b as l,e as g,f as v,g as c,h as y,i as b}from"./chunks/ReCaptchaVuePlugin.js";import{u as _,r as d,e as k}from"./chunks/index.js";import{_ as w}from"./chunks/_plugin-vue_export-helper.js";import"./chunks/_commonjsHelpers.js";const T=h({props:{submitApi:{type:String,default:void 0}},setup(){return{v$:_()}},data(){return{loading:!1,form:{gRecaptchaToken:"",firstName:"",lastName:"",email:"",enquiryType:"",message:"",phone:"",subscribe:!1},response:{message:"",success:!1}}},validations(){return{form:{firstName:{required:d},lastName:{required:d},email:{required:d,email:k},enquiryType:{required:d},message:{required:d}}}},mounted(){},methods:{async getRecaptchaToken(){try{const s=await this.$recaptcha("login");return s||console.error("There was no Google reCAPTCHA token returned."),s}catch(s){return console.error(s),""}},async doSubmitForm(){if(!(this.loading||!await this.v$.$validate())){this.loading=!0,this.form.gRecaptchaToken=await this.getRecaptchaToken();try{const o={...this.form},p=await fetch(this.submitApi,{method:"POST",headers:{"Content-Type":"application/json"},body:JSON.stringify(o)}),m=await p.json();m.redirectUrl?window.location.href=m.redirectUrl:(this.response.success=p.status===200,this.response.message=m.message)}catch(o){console.error("Submit error:",o),this.response.success=!1,this.response.message="Sorry, something went wrong! Please try again later."}finally{this.loading=!1}}}}}),S={class:"cc-contact-form-form"},$={key:0,class:"rounded-md bg-green-50 p-4"},q={class:"flex items-center"},N=e("div",{class:"flex-shrink-0"},[e("svg",{class:"h-5 w-5 text-green-400",viewBox:"0 0 20 20",fill:"currentColor","aria-hidden":"true"},[e("path",{"fill-rule":"evenodd",d:"M10 18a8 8 0 100-16 8 8 0 000 16zm3.857-9.809a.75.75 0 00-1.214-.882l-3.483 4.79-1.88-1.88a.75.75 0 10-1.06 1.061l2.5 2.5a.75.75 0 001.137-.089l4-5.5z","clip-rule":"evenodd"})])],-1),V={class:"ml-3"},C={class:"text-green-700"},P={key:1,class:"rounded-md bg-red-50 p-4"},x={class:"flex"},M=e("div",{class:"flex-shrink-0"},[e("svg",{class:"h-5 w-5 text-red-400",viewBox:"0 0 20 20",fill:"currentColor","aria-hidden":"true"},[e("path",{"fill-rule":"evenodd",d:"M10 18a8 8 0 100-16 8 8 0 000 16zM8.28 7.22a.75.75 0 00-1.06 1.06L8.94 10l-1.72 1.72a.75.75 0 101.06 1.06L10 11.06l1.72 1.72a.75.75 0 101.06-1.06L11.06 10l1.72-1.72a.75.75 0 00-1.06-1.06L10 8.94 8.28 7.22z","clip-rule":"evenodd"})])],-1),U={class:"ml-3"},F={class:"text-red-700"},A={class:"grid grid-cols-2 gap-x-7 gap-y-5"},E={class:"field col-span-2 md:col-span-1"},R=e("label",{for:"contact-form-first-name"},"First name",-1),z={class:"control mt-2"},B={key:0,class:"mt-2 text-sm text-rose-700"},L={class:"field col-span-2 md:col-span-1"},O=e("label",{for:"contact-form-last-name"},"Last name",-1),j={class:"control mt-2"},G={key:0,class:"mt-2 text-sm text-rose-700"},D={class:"field col-span-2 md:col-span-1"},H=e("label",{for:"contact-form-email"},"Email address",-1),I={class:"control mt-2"},J={key:0,class:"mt-2 text-sm text-rose-700"},K={class:"field col-span-2 md:col-span-1"},Q=e("label",{for:"contact-form-phone"},"Phone",-1),W={class:"control mt-2"},X={class:"field col-span-2 md:col-span-1"},Y=e("label",{for:"contact-form-enquiry-type"},"Type of enquiry",-1),Z={class:"control mt-2"},ee=b('<option value="General Enquiry">General Enquiry</option><option value="Media Enquiry">Media Enquiry</option><option value="Sponsorship">Sponsorship</option><option value="Project enquiry">Project enquiry</option><option value="Supplier/Contractor">Supplier/Contractor</option><option value="Other">Other</option>',6),se=[ee],oe={key:0,class:"mt-2 text-sm text-rose-700"},te={class:"field col-span-2"},re=e("label",{for:"contact-form-message"},"Message",-1),ae={class:"control mt-2"},ie={key:0,class:"mt-2 text-sm text-rose-700"},ne={class:"field col-span-2"},le={class:"inline-flex items-center"},de=e("span",{class:"ml-2"},"I would like to subscribe to the Abergeldie newsletter.",-1),me=e("div",{class:"google-notice col-span-2"},[e("div",{class:"prose text-sm text-abergeldie-silver"},[c(" This site is protected by reCAPTCHA and the Google "),e("a",{href:"https://policies.google.com/privacy",target:"_blank"},"Privacy Policy"),c(" and "),e("a",{href:"https://policies.google.com/terms",target:"_blank"},"Terms of Service"),c(" apply. ")])],-1),ce={class:"row lg:-mx-3 lg:flex"},pe={class:"field mt-11 lg:px-3"},ue=e("span",{class:"spinner"},null,-1);function fe(s,o,p,m,he,ge){return r(),a("div",S,[e("div",{ref:"response-message",class:f([{hidden:!s.response.message},"mb-6"])},[s.response.success?(r(),a("div",$,[e("div",q,[N,e("div",V,[e("div",C,u(s.response.message),1)])])])):(r(),a("div",P,[e("div",x,[M,e("div",U,[e("div",F,u(s.response.message),1)])])]))],2),e("form",{ref:"form",onSubmit:o[8]||(o[8]=y((...t)=>s.doSubmitForm&&s.doSubmitForm(...t),["prevent"]))},[e("div",A,[e("div",E,[R,e("div",z,[i(e("input",{id:"contact-form-first-name","onUpdate:modelValue":o[0]||(o[0]=t=>s.form.firstName=t),name:"firstName",class:"w-full rounded border-abergeldie-stroke",type:"text",placeholder:""},null,512),[[n,s.form.firstName]])]),s.v$.form.firstName.$errors.length?(r(),a("div",B,"Please enter your first name")):l("",!0)]),e("div",L,[O,e("div",j,[i(e("input",{id:"contact-form-last-name","onUpdate:modelValue":o[1]||(o[1]=t=>s.form.lastName=t),name:"lastName",class:"w-full rounded border-abergeldie-stroke",type:"text",placeholder:""},null,512),[[n,s.form.lastName]])]),s.v$.form.lastName.$errors.length?(r(),a("div",G,"Please enter your last name")):l("",!0)]),e("div",D,[H,e("div",I,[i(e("input",{id:"contact-form-email","onUpdate:modelValue":o[2]||(o[2]=t=>s.form.email=t),name:"email",class:"w-full rounded border-abergeldie-stroke",type:"email",placeholder:""},null,512),[[n,s.form.email]])]),s.v$.form.email.$errors.length?(r(),a("div",J,"Please enter a valid email address")):l("",!0)]),e("div",K,[Q,e("div",W,[i(e("input",{id:"contact-form-phone","onUpdate:modelValue":o[3]||(o[3]=t=>s.form.phone=t),name:"phone",class:"w-full rounded border-abergeldie-stroke",type:"tel",placeholder:"Optional"},null,512),[[n,s.form.phone]])])]),e("div",X,[Y,e("div",Z,[i(e("select",{id:"contact-form-enquiry-type","onUpdate:modelValue":o[4]||(o[4]=t=>s.form.enquiryType=t),name:"enquiryType",class:"w-full rounded border-abergeldie-stroke"},se,512),[[g,s.form.enquiryType]])]),s.v$.form.enquiryType.$errors.length?(r(),a("div",oe,"Please select an enquiry type")):l("",!0)]),e("div",te,[re,e("div",ae,[i(e("textarea",{id:"contact-form-message","onUpdate:modelValue":o[5]||(o[5]=t=>s.form.message=t),name:"message",class:"min-h-[100px] w-full rounded border-abergeldie-stroke",placeholder:""},null,512),[[n,s.form.message]])]),s.v$.form.message.$errors.length?(r(),a("div",ie,"Please enter a message")):l("",!0)]),e("div",ne,[e("label",le,[i(e("input",{"onUpdate:modelValue":o[6]||(o[6]=t=>s.form.subscribe=t),type:"checkbox",name:"subscribe",class:"rounded border-abergeldie-stroke"},null,512),[[v,s.form.subscribe]]),de])]),me]),i(e("input",{"onUpdate:modelValue":o[7]||(o[7]=t=>s.form.gRecaptchaToken=t),type:"hidden",name:"g_recaptcha_response"},null,512),[[n,s.form.gRecaptchaToken]]),e("div",ce,[e("div",pe,[e("button",{type:"submit",class:f([{loading:s.loading},"btn btn-primary min-w-40"])},[c(" Submit "),ue],2)])])],544)])}const ke=w(T,[["render",fe]]);export{ke as default};