import{V as m,d as p,O as a,P as S,Q as $,S as g}from"./chunks/ReCaptchaVuePlugin.js";import{a as y,b as R,c as h,C as E,d as I,f as b,g as _,E as C,h as H,i as P,H as x,j as O,I as M,k as j,l as B,m as D,n as T,o as v,p as L,q as Q,r as k,s as w,Q as V,t as z,e as F,u as W,v as K,w as N,x as U,y as q,z as X,A as Y,B as G,D as J,F as Z}from"./chunks/ExperimentalDynamicWidgets.js";import"./chunks/_commonjsHelpers.js";import"./chunks/history.js";const o=Object.freeze(Object.defineProperty({__proto__:null,AisAutocomplete:y,AisBreadcrumb:R,AisClearRefinements:h,AisConfigure:E,AisCurrentRefinements:I,AisDynamicWidgets:b,AisExperimentalConfigureRelatedItems:_,AisExperimentalDynamicWidgets:C,AisHierarchicalMenu:H,AisHighlight:P,AisHits:x,AisHitsPerPage:O,AisIndex:M,AisInfiniteHits:j,AisInstantSearch:B,AisInstantSearchSsr:D,AisMenu:T,AisMenuSelect:v,AisNumericMenu:L,AisPagination:Q,AisPanel:k,AisPoweredBy:w,AisQueryRuleContext:V,AisQueryRuleCustomData:z,AisRangeInput:F,AisRatingMenu:W,AisRefinementList:K,AisRelevantSort:N,AisSearchBox:U,AisSnippet:q,AisSortBy:X,AisStateResults:Y,AisStats:G,AisToggleRefinement:J,AisVoiceSearch:Z},Symbol.toStringTag,{value:"Module"}));var ee={install:function(e){Object.keys(o).forEach(function(s){e.component(o[s].name,o[s])})}};const l=e=>{e.use(ee),e.use(m,{siteKey:{BASE_URL:"/",MODE:"production",DEV:!1,PROD:!0,SSR:!1,SITE:void 0,ASSETS_PREFIX:void 0}.PUBLIC_RECAPTCHA_SITE_KEY,loaderOptions:{}})},se=Object.freeze(Object.defineProperty({__proto__:null,default:l},Symbol.toStringTag,{value:"Module"})),te=p({props:{value:String,name:String,hydrate:{type:Boolean,default:!0}},setup({name:e,value:s,hydrate:n}){if(!s)return()=>null;let i=n?"astro-slot":"astro-static-slot";return()=>a(i,{name:e,innerHTML:s})}}),ae=async e=>{"default"in se&&await l(e)},le=e=>async(s,n,i,{client:A})=>{if(!e.hasAttribute("ssr"))return;const f=s.name?`${s.name} Host`:void 0,u={};for(const[t,d]of Object.entries(i))u[t]=()=>a(te,{value:d,name:t==="default"?void 0:t});const c=A!=="only",r=(c?S:$)({name:f,render(){let t=a(s,n,u);return ne(s.setup)&&(t=a(g,null,t)),t}});await ae(r),r.mount(e,c),e.addEventListener("astro:unmount",()=>r.unmount(),{once:!0})};function ne(e){const s=e?.constructor;return s&&s.name==="AsyncFunction"}export{le as default};
