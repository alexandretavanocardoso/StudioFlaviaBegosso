<template>
    <div>
        <component :is="navigatePage"></component>
    </div>
</template>

<script>
import AboutMeComponent from '@/components/studio-components/about-me/AboutMe.vue'
import AllWorksComponent from '@/components/studio-components/all-works/AllWorks.vue'
import ContactComponent from '@/components/studio-components/contact/Contact.vue'

export default {
    name: 'ContentComponent',
    data: () => ({
        navigatePage: 'ContactComponent'
    }),
    components: {
        AboutMeComponent,
        AllWorksComponent,
        ContactComponent
    }
}
</script>