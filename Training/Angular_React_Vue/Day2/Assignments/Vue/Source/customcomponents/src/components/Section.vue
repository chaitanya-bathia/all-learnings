<template>
    
    <div>
        <h2>This section contains calls for Home and about Pages</h2>

        <home-component></home-component>
        <about-component></about-component>
    </div>

</template>

<script>
import HomeComponent from './Home.vue';
import AboutComponent from './About.vue'

export default{
    name:'SectionComponent',
    components:
    {
        HomeComponent,
        AboutComponent
    }
}

</script>