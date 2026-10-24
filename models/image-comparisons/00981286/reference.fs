FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E0.bottom", {"start": v(-4.25, 0) * mm, "end": v(-20, 0) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(-4.25, 2) * mm, "end": v(-20, 2) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(-20, 0) * mm, "end": v(-20, 2) * mm});
            skLineSegment(sketch, "E1.top", {"start": v(-4.25, 4) * mm, "end": v(-18, 4) * mm});
            skLineSegment(sketch, "E1.right", {"start": v(-18, 2) * mm, "end": v(-18, 4) * mm});
            skLineSegment(sketch, "E2.bottom", {"start": v(-4.25, 4) * mm, "end": v(-20, 4) * mm});
            skLineSegment(sketch, "E2.top", {"start": v(-4.25, 6) * mm, "end": v(-20, 6) * mm});
            skLineSegment(sketch, "E2.right", {"start": v(-20, 4) * mm, "end": v(-20, 6) * mm});
            skLineSegment(sketch, "E3.bottom", {"start": v(-4.25, 6) * mm, "end": v(-18, 6) * mm});
            skLineSegment(sketch, "E3.top", {"start": v(-4.25, 8) * mm, "end": v(-18, 8) * mm});
            skLineSegment(sketch, "E3.right", {"start": v(-18, 6) * mm, "end": v(-18, 8) * mm});
            skLineSegment(sketch, "E4.bottom", {"start": v(-4.25, 8) * mm, "end": v(-20, 8) * mm});
            skLineSegment(sketch, "E4.top", {"start": v(-4.25, 10) * mm, "end": v(-20, 10) * mm});
            skLineSegment(sketch, "E4.right", {"start": v(-20, 8) * mm, "end": v(-20, 10) * mm});
            skLineSegment(sketch, "E5", {"start": v(-4.25, 10) * mm, "end": v(-4.25, 0) * mm});
            skLineSegment(sketch, "E6", {"start": v(0, 0) * mm, "end": v(0, 10) * mm});
            skPoint(sketch, "E7.orphan", {"position": v(-18, 1.98) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E3.bottom");Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":subQ0}),-1.0]])]});}
            var Q1;
            {var subQ5=sQuery(id+"F0.wireOp",EDGE,"E0.bottom");Q1=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":subQ5}),-1.0]])]});}
            var Q2;
            {var subQ1=sQuery(id+"F0.wireOp",EDGE,"E4.top");Q2=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":subQ1}),1.0]])]});}
            var Q3;
            {var subQ3=sQuery(id+"F0.wireOp",EDGE,"E1.right");Q3=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":subQ3}),-1.0]])]});}
            var Q4;
            Q4=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E2.top")}),1.0]])]});
            var Q5;
            Q5=sQuery(id+"F0.wireOp",EDGE,"E6");
            revolve(context, id + "F1", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4]), "axis" : qUnion([Q5]), "revolveType" : RevolveType.FULL});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opRevolve","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4.top"),sQuery(id+"F0.wireOp",EDGE,"E4.right")])]});
            var Q1;
            Q1=makeQuery(id+"F1.opRevolve","SWEPT_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4.bottom"),sQuery(id+"F0.wireOp",EDGE,"E4.right")])]});
            var Q2;
            Q2=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4.right")])]});
            var Q3;
            Q3=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E2.right")])]});
            var Q4;
            Q4=makeQuery(id+"F1.opRevolve","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.right")])]});
            chamfer(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4]), "width" : .2 * mm, "tangentPropagation" : true});
        }
    });